// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2022 Datadog, Inc.

#pragma once
#include "IConfiguration.h"
#include "IExporter.h"
#include "TagsHelper.h"

extern "C"
{
#include "ddprof/ffi.h"
}

#include <forward_list>
#include <memory>
#include <string_view>
#include <unordered_map>
#include <vector>

class Sample;
class IMetricsSender;
class IApplicationStore;

class LibddprofExporter : public IExporter
{
public:
    LibddprofExporter(IConfiguration* configuration, IApplicationStore* applicationStore);
    ~LibddprofExporter() override;
    bool Export() override;
    void Add(Sample const& sample) override;

private:
    class SerializedProfile
    {
    public:
        SerializedProfile(struct ddprof_ffi_Profile* profile);
        ~SerializedProfile();

        ddprof_ffi_Buffer GetBuffer() const;
        ddprof_ffi_Timespec GetStart() const;
        ddprof_ffi_Timespec GetEnd() const;

        bool IsValid() const;

    private:
        struct ddprof_ffi_EncodedProfile* _encodedProfile;
    };

    class Tags
    {
    public:
        void Add(std::string const& name, std::string const& value);

        ddprof_ffi_Slice_tag GetFfiTags() const;

    private:
        std::forward_list<std::pair<std::string, std::string>> _stringTags;
        std::vector<ddprof_ffi_Tag> _ffiTags;
    };

    class ProfileAutoReset
    {
    public:
        ProfileAutoReset(struct ddprof_ffi_Profile* profile);
        ~ProfileAutoReset();

    private:
        struct ddprof_ffi_Profile* _profile;
    };

    static Tags CreateTags(IConfiguration* configuration);
    static ddprof_ffi_ProfileExporterV3* CreateExporter(ddprof_ffi_Slice_tag tags, ddprof_ffi_EndpointV3 endpoint);
    static ddprof_ffi_Profile* CreateProfile();

    ddprof_ffi_Request* CreateRequest(SerializedProfile const& encodedProfile, ddprof_ffi_ProfileExporterV3* exporter) const;
    ddprof_ffi_EndpointV3 CreateEndpoint(IConfiguration* configuration);
    std::pair<ddprof_ffi_Profile*, std::int32_t>& GetProfileAndSamplesCount(std::string_view runtimeId);


    void ExportToDisk(const std::string& applicationName, SerializedProfile const& encodedProfile, int idx);

    bool Send(ddprof_ffi_Request* request, ddprof_ffi_ProfileExporterV3* exporter) const;
    std::string GeneratePprofFilePath(const std::string& applicationName, int idx) const;
    fs::path CreatePprofOutputPath(IConfiguration* configuration) const;

    static tags CommonTags;
    static std::string const ProcessId;
    static int const RequestTimeOutMs;
    static std::string const LanguageFamily;

    // TODO: this should be passed in the constructor to avoid overwriting
    //       the .pprof generated by the managed side
    static std::string const RequestFileName;
    static std::string const ProfilePeriodType;
    static std::string const ProfilePeriodUnit;

    fs::path _pprofOutputPath;

    std::vector<ddprof_ffi_Location> _locations;
    std::vector<ddprof_ffi_Line> _lines;
    std::string _agentUrl;
    std::size_t _locationsAndLinesSize;
    std::unordered_map<std::string_view, std::pair<ddprof_ffi_Profile*, std::int32_t>> _profilePerApplication;
    ddprof_ffi_EndpointV3 _endpoint;
    Tags _exporterBaseTags;
    IApplicationStore* const _applicationStore;
};