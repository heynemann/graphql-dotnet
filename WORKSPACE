workspace(
    name = "grapql_dotnet",
)

load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")

git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet",
    commit = "e6415707f7e26756456d2473b9b22dfbeff66171",
    shallow_since = "1589455349 +0200",
)

load("@io_bazel_rules_dotnet//dotnet:deps.bzl", "dotnet_repositories")

dotnet_repositories()

load(
    "@io_bazel_rules_dotnet//dotnet:defs.bzl",
    "core_register_sdk",
    "dotnet_register_toolchains",
    "dotnet_repositories_nugets",
    "nuget_package",
)

dotnet_register_toolchains()
dotnet_repositories_nugets()
core_register_sdk("v3.1.100", name = "core_sdk")

### Generated by the tool
nuget_package(
    name = "newtonsoft.json",
    package = "newtonsoft.json",
    version = "12.0.3",
    sha256 = "3d21caf909f9db2b5d13249d6728c2506c55e72e2123fbe2af65a056c0a0bf9d",
    core_lib = {
        "netcoreapp2.0": "lib/netstandard2.0/Newtonsoft.Json.dll",
        "netcoreapp2.1": "lib/netstandard2.0/Newtonsoft.Json.dll",
        "netcoreapp3.0": "lib/netstandard2.0/Newtonsoft.Json.dll",
        "netcoreapp3.1": "lib/netstandard2.0/Newtonsoft.Json.dll",
    },
    net_lib = {
        "net45": "lib/net45/Newtonsoft.Json.dll",
        "net451": "lib/net45/Newtonsoft.Json.dll",
        "net452": "lib/net45/Newtonsoft.Json.dll",
        "net46": "lib/net45/Newtonsoft.Json.dll",
        "net461": "lib/net45/Newtonsoft.Json.dll",
        "net462": "lib/net45/Newtonsoft.Json.dll",
        "net47": "lib/net45/Newtonsoft.Json.dll",
        "net471": "lib/net45/Newtonsoft.Json.dll",
        "net472": "lib/net45/Newtonsoft.Json.dll",
        "net48": "lib/net45/Newtonsoft.Json.dll",
        "netstandard1.0": "lib/netstandard1.0/Newtonsoft.Json.dll",
        "netstandard1.1": "lib/netstandard1.0/Newtonsoft.Json.dll",
        "netstandard1.2": "lib/netstandard1.0/Newtonsoft.Json.dll",
        "netstandard1.3": "lib/netstandard1.3/Newtonsoft.Json.dll",
        "netstandard1.4": "lib/netstandard1.3/Newtonsoft.Json.dll",
        "netstandard1.5": "lib/netstandard1.3/Newtonsoft.Json.dll",
        "netstandard1.6": "lib/netstandard1.3/Newtonsoft.Json.dll",
        "netstandard2.0": "lib/netstandard2.0/Newtonsoft.Json.dll",
        "netstandard2.1": "lib/netstandard2.0/Newtonsoft.Json.dll",
    },
    mono_lib = "lib/net45/Newtonsoft.Json.dll",
    core_files = {
        "netcoreapp2.0": [
            "lib/netstandard2.0/Newtonsoft.Json.dll",
            "lib/netstandard2.0/Newtonsoft.Json.xml",
        ],
        "netcoreapp2.1": [
            "lib/netstandard2.0/Newtonsoft.Json.dll",
            "lib/netstandard2.0/Newtonsoft.Json.xml",
        ],
        "netcoreapp3.0": [
            "lib/netstandard2.0/Newtonsoft.Json.dll",
            "lib/netstandard2.0/Newtonsoft.Json.xml",
        ],
        "netcoreapp3.1": [
            "lib/netstandard2.0/Newtonsoft.Json.dll",
            "lib/netstandard2.0/Newtonsoft.Json.xml",
        ],
    },
    net_files = {
        "net45": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "net451": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "net452": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "net46": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "net461": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "net462": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "net47": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "net471": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "net472": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "net48": [
            "lib/net45/Newtonsoft.Json.dll",
            "lib/net45/Newtonsoft.Json.xml",
        ],
        "netstandard1.0": [
            "lib/netstandard1.0/Newtonsoft.Json.dll",
            "lib/netstandard1.0/Newtonsoft.Json.xml",
        ],
        "netstandard1.1": [
            "lib/netstandard1.0/Newtonsoft.Json.dll",
            "lib/netstandard1.0/Newtonsoft.Json.xml",
        ],
        "netstandard1.2": [
            "lib/netstandard1.0/Newtonsoft.Json.dll",
            "lib/netstandard1.0/Newtonsoft.Json.xml",
        ],
        "netstandard1.3": [
            "lib/netstandard1.3/Newtonsoft.Json.dll",
            "lib/netstandard1.3/Newtonsoft.Json.xml",
        ],
        "netstandard1.4": [
            "lib/netstandard1.3/Newtonsoft.Json.dll",
            "lib/netstandard1.3/Newtonsoft.Json.xml",
        ],
        "netstandard1.5": [
            "lib/netstandard1.3/Newtonsoft.Json.dll",
            "lib/netstandard1.3/Newtonsoft.Json.xml",
        ],
        "netstandard1.6": [
            "lib/netstandard1.3/Newtonsoft.Json.dll",
            "lib/netstandard1.3/Newtonsoft.Json.xml",
        ],
        "netstandard2.0": [
            "lib/netstandard2.0/Newtonsoft.Json.dll",
            "lib/netstandard2.0/Newtonsoft.Json.xml",
        ],
        "netstandard2.1": [
            "lib/netstandard2.0/Newtonsoft.Json.dll",
            "lib/netstandard2.0/Newtonsoft.Json.xml",
        ],
    },
    mono_files = [
        "lib/net45/Newtonsoft.Json.dll",
        "lib/net45/Newtonsoft.Json.xml",
    ],
)
nuget_package(
    name = "graphql-parser",
    package = "graphql-parser",
    version = "5.1.2",
    sha256 = "0cf82d26bce818baedf3351e0b05c237564443cf356c615ef33711bac8dba56c",
    core_lib = {
        "netcoreapp2.0": "lib/netstandard2.0/GraphQL-Parser.dll",
        "netcoreapp2.1": "lib/netstandard2.0/GraphQL-Parser.dll",
        "netcoreapp3.0": "lib/netstandard2.0/GraphQL-Parser.dll",
        "netcoreapp3.1": "lib/netstandard2.0/GraphQL-Parser.dll",
    },
    net_lib = {
        "net461": "lib/netstandard2.0/GraphQL-Parser.dll",
        "net462": "lib/netstandard2.0/GraphQL-Parser.dll",
        "net47": "lib/netstandard2.0/GraphQL-Parser.dll",
        "net471": "lib/netstandard2.0/GraphQL-Parser.dll",
        "net472": "lib/netstandard2.0/GraphQL-Parser.dll",
        "net48": "lib/netstandard2.0/GraphQL-Parser.dll",
        "netstandard2.0": "lib/netstandard2.0/GraphQL-Parser.dll",
        "netstandard2.1": "lib/netstandard2.0/GraphQL-Parser.dll",
    },
    mono_lib = "lib/netstandard2.0/GraphQL-Parser.dll",
    core_files = {
        "netcoreapp2.0": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "netcoreapp2.1": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "netcoreapp3.0": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "netcoreapp3.1": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
    },
    net_files = {
        "net461": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "net462": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "net47": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "net471": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "net472": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "net48": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "netstandard2.0": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
        "netstandard2.1": [
            "lib/netstandard2.0/GraphQL-Parser.dll",
        ],
    },
    mono_files = [
        "lib/netstandard2.0/GraphQL-Parser.dll",
    ],
)
nuget_package(
    name = "system.runtime.compilerservices.unsafe",
    package = "system.runtime.compilerservices.unsafe",
    version = "4.7.1",
    sha256 = "52fca80d5f0ed286371cf1b519b039e9855dbf04c611f8d8479816d4eec82b85",
    core_lib = {
        "netcoreapp2.0": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp2.1": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp3.0": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp3.1": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
    },
    core_ref = {
        "netcoreapp2.0": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp2.1": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp3.0": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp3.1": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
    },
    net_lib = {
        "net45": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net451": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net452": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net46": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net461": "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net462": "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net47": "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net471": "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net472": "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net48": "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.0": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.1": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.2": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.3": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.4": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.5": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.6": "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard2.0": "lib/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard2.1": "lib/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
    },
    net_ref = {
        "net45": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net451": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net452": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net46": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net461": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net462": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net47": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net471": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net472": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net48": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.0": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.1": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.2": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.3": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.4": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.5": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.6": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard2.0": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard2.1": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
    },
    mono_lib = "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
    mono_ref = "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
    core_files = {
        "netcoreapp2.0": [
            "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netcoreapp2.1": [
            "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netcoreapp3.0": [
            "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netcoreapp3.1": [
            "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
    },
    net_files = {
        "net45": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net451": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net452": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net46": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net461": [
            "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net462": [
            "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net47": [
            "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net471": [
            "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net472": [
            "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net48": [
            "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.0": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.1": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.2": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.3": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.4": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.5": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.6": [
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard2.0": [
            "lib/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard2.1": [
            "lib/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
            "lib/netstandard2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
    },
    mono_files = [
        "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
    ],
)
nuget_package(
    name = "system.threading.tasks.extensions",
    package = "system.threading.tasks.extensions",
    version = "4.5.4",
    sha256 = "a304a963cc0796c5179f9c6b7d8022bbce3b2fa7c029eb6196f631f7b462d678",
    core_lib = {
        "netcoreapp2.0": "lib/netstandard2.0/System.Threading.Tasks.Extensions.dll",
    },
    net_lib = {
        "net45": "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.dll",
        "net451": "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.dll",
        "net452": "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.dll",
        "net46": "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.dll",
        "net461": "lib/net461/System.Threading.Tasks.Extensions.dll",
        "net462": "lib/net461/System.Threading.Tasks.Extensions.dll",
        "net47": "lib/net461/System.Threading.Tasks.Extensions.dll",
        "net471": "lib/net461/System.Threading.Tasks.Extensions.dll",
        "net472": "lib/net461/System.Threading.Tasks.Extensions.dll",
        "net48": "lib/net461/System.Threading.Tasks.Extensions.dll",
        "netstandard1.0": "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
        "netstandard1.1": "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
        "netstandard1.2": "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
        "netstandard1.3": "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
        "netstandard1.4": "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
        "netstandard1.5": "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
        "netstandard1.6": "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
        "netstandard2.0": "lib/netstandard2.0/System.Threading.Tasks.Extensions.dll",
        "netstandard2.1": "lib/netstandard2.0/System.Threading.Tasks.Extensions.dll",
    },
    mono_lib = "lib/net461/System.Threading.Tasks.Extensions.dll",
    core_deps = {
        "netcoreapp2.0": [
            "@system.runtime.compilerservices.unsafe//:netcoreapp2.0_core",
        ],
    },
    net_deps = {
        "net45": [
            "@system.runtime.compilerservices.unsafe//:net45_net",
        ],
        "net451": [
            "@system.runtime.compilerservices.unsafe//:net451_net",
        ],
        "net452": [
            "@system.runtime.compilerservices.unsafe//:net452_net",
        ],
        "net46": [
            "@system.runtime.compilerservices.unsafe//:net46_net",
        ],
        "net461": [
            "@system.runtime.compilerservices.unsafe//:net461_net",
        ],
        "net462": [
            "@system.runtime.compilerservices.unsafe//:net462_net",
        ],
        "net47": [
            "@system.runtime.compilerservices.unsafe//:net47_net",
        ],
        "net471": [
            "@system.runtime.compilerservices.unsafe//:net471_net",
        ],
        "net472": [
            "@system.runtime.compilerservices.unsafe//:net472_net",
        ],
        "net48": [
            "@system.runtime.compilerservices.unsafe//:net48_net",
        ],
        "netstandard1.0": [
            "@system.runtime.compilerservices.unsafe//:netstandard1.0_net",
        ],
        "netstandard1.1": [
            "@system.runtime.compilerservices.unsafe//:netstandard1.1_net",
        ],
        "netstandard1.2": [
            "@system.runtime.compilerservices.unsafe//:netstandard1.2_net",
        ],
        "netstandard1.3": [
            "@system.runtime.compilerservices.unsafe//:netstandard1.3_net",
        ],
        "netstandard1.4": [
            "@system.runtime.compilerservices.unsafe//:netstandard1.4_net",
        ],
        "netstandard1.5": [
            "@system.runtime.compilerservices.unsafe//:netstandard1.5_net",
        ],
        "netstandard1.6": [
            "@system.runtime.compilerservices.unsafe//:netstandard1.6_net",
        ],
        "netstandard2.0": [
            "@system.runtime.compilerservices.unsafe//:netstandard2.0_net",
        ],
        "netstandard2.1": [
            "@system.runtime.compilerservices.unsafe//:netstandard2.1_net",
        ],
    },
    mono_deps = [
        "@system.runtime.compilerservices.unsafe//:mono",
    ],
    core_files = {
        "netcoreapp2.0": [
            "lib/netstandard2.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard2.0/System.Threading.Tasks.Extensions.xml",
        ],
    },
    net_files = {
        "net45": [
            "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.dll",
            "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.xml",
        ],
        "net451": [
            "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.dll",
            "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.xml",
        ],
        "net452": [
            "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.dll",
            "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.xml",
        ],
        "net46": [
            "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.dll",
            "lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.xml",
        ],
        "net461": [
            "lib/net461/System.Threading.Tasks.Extensions.dll",
            "lib/net461/System.Threading.Tasks.Extensions.xml",
        ],
        "net462": [
            "lib/net461/System.Threading.Tasks.Extensions.dll",
            "lib/net461/System.Threading.Tasks.Extensions.xml",
        ],
        "net47": [
            "lib/net461/System.Threading.Tasks.Extensions.dll",
            "lib/net461/System.Threading.Tasks.Extensions.xml",
        ],
        "net471": [
            "lib/net461/System.Threading.Tasks.Extensions.dll",
            "lib/net461/System.Threading.Tasks.Extensions.xml",
        ],
        "net472": [
            "lib/net461/System.Threading.Tasks.Extensions.dll",
            "lib/net461/System.Threading.Tasks.Extensions.xml",
        ],
        "net48": [
            "lib/net461/System.Threading.Tasks.Extensions.dll",
            "lib/net461/System.Threading.Tasks.Extensions.xml",
        ],
        "netstandard1.0": [
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.xml",
        ],
        "netstandard1.1": [
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.xml",
        ],
        "netstandard1.2": [
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.xml",
        ],
        "netstandard1.3": [
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.xml",
        ],
        "netstandard1.4": [
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.xml",
        ],
        "netstandard1.5": [
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.xml",
        ],
        "netstandard1.6": [
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard1.0/System.Threading.Tasks.Extensions.xml",
        ],
        "netstandard2.0": [
            "lib/netstandard2.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard2.0/System.Threading.Tasks.Extensions.xml",
        ],
        "netstandard2.1": [
            "lib/netstandard2.0/System.Threading.Tasks.Extensions.dll",
            "lib/netstandard2.0/System.Threading.Tasks.Extensions.xml",
        ],
    },
    mono_files = [
        "lib/net461/System.Threading.Tasks.Extensions.dll",
        "lib/net461/System.Threading.Tasks.Extensions.xml",
    ],
)
nuget_package(
    name = "system.valuetuple",
    package = "system.valuetuple",
    version = "4.5.0",
    sha256 = "9e21fa9767d4e76bc0cee065c1d40cc34384a114bfec4d70e6c981168a926802",
    net_lib = {
        "net45": "lib/netstandard1.0/System.ValueTuple.dll",
        "net451": "lib/netstandard1.0/System.ValueTuple.dll",
        "net452": "lib/netstandard1.0/System.ValueTuple.dll",
        "net46": "lib/netstandard1.0/System.ValueTuple.dll",
        "net461": "lib/net461/System.ValueTuple.dll",
        "net462": "lib/net461/System.ValueTuple.dll",
        "net47": "lib/net47/System.ValueTuple.dll",
        "net471": "lib/net47/System.ValueTuple.dll",
        "net472": "lib/net47/System.ValueTuple.dll",
        "net48": "lib/net47/System.ValueTuple.dll",
        "netstandard1.0": "lib/netstandard1.0/System.ValueTuple.dll",
        "netstandard1.1": "lib/netstandard1.0/System.ValueTuple.dll",
        "netstandard1.2": "lib/netstandard1.0/System.ValueTuple.dll",
        "netstandard1.3": "lib/netstandard1.0/System.ValueTuple.dll",
        "netstandard1.4": "lib/netstandard1.0/System.ValueTuple.dll",
        "netstandard1.5": "lib/netstandard1.0/System.ValueTuple.dll",
        "netstandard1.6": "lib/netstandard1.0/System.ValueTuple.dll",
    },
    net_ref = {
        "net45": "ref/portable-net40+sl4+win8+wp8/System.ValueTuple.dll",
        "net451": "ref/portable-net40+sl4+win8+wp8/System.ValueTuple.dll",
        "net452": "ref/portable-net40+sl4+win8+wp8/System.ValueTuple.dll",
        "net46": "ref/portable-net40+sl4+win8+wp8/System.ValueTuple.dll",
        "net461": "ref/net461/System.ValueTuple.dll",
        "net462": "ref/net461/System.ValueTuple.dll",
        "net47": "ref/net47/System.ValueTuple.dll",
        "net471": "ref/net47/System.ValueTuple.dll",
        "net472": "ref/net47/System.ValueTuple.dll",
        "net48": "ref/net47/System.ValueTuple.dll",
    },
    mono_lib = "lib/net47/System.ValueTuple.dll",
    mono_ref = "ref/net47/System.ValueTuple.dll",
    net_files = {
        "net45": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "net451": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "net452": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "net46": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "net461": [
            "lib/net461/System.ValueTuple.dll",
            "lib/net461/System.ValueTuple.xml",
        ],
        "net462": [
            "lib/net461/System.ValueTuple.dll",
            "lib/net461/System.ValueTuple.xml",
        ],
        "net47": [
            "lib/net47/System.ValueTuple.dll",
            "lib/net47/System.ValueTuple.xml",
        ],
        "net471": [
            "lib/net47/System.ValueTuple.dll",
            "lib/net47/System.ValueTuple.xml",
        ],
        "net472": [
            "lib/net47/System.ValueTuple.dll",
            "lib/net47/System.ValueTuple.xml",
        ],
        "net48": [
            "lib/net47/System.ValueTuple.dll",
            "lib/net47/System.ValueTuple.xml",
        ],
        "netstandard1.0": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "netstandard1.1": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "netstandard1.2": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "netstandard1.3": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "netstandard1.4": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "netstandard1.5": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
        "netstandard1.6": [
            "lib/netstandard1.0/System.ValueTuple.dll",
            "lib/netstandard1.0/System.ValueTuple.xml",
        ],
    },
    mono_files = [
        "lib/net47/System.ValueTuple.dll",
        "lib/net47/System.ValueTuple.xml",
    ],
)
nuget_package(
    name = "system.reactive",
    package = "system.reactive",
    version = "4.4.1",
    sha256 = "8a703a9f0f425f483f01eca033026801118e63bf69962fe32c5e780b0794a83f",
    core_lib = {
        "netcoreapp2.0": "lib/netstandard2.0/System.Reactive.dll",
        "netcoreapp2.1": "lib/netstandard2.0/System.Reactive.dll",
    },
    net_lib = {
        "net46": "lib/net46/System.Reactive.dll",
        "net461": "lib/net46/System.Reactive.dll",
        "net462": "lib/net46/System.Reactive.dll",
        "net47": "lib/net46/System.Reactive.dll",
        "net471": "lib/net46/System.Reactive.dll",
        "net472": "lib/net46/System.Reactive.dll",
        "net48": "lib/net46/System.Reactive.dll",
        "netstandard2.0": "lib/netstandard2.0/System.Reactive.dll",
        "netstandard2.1": "lib/netstandard2.0/System.Reactive.dll",
    },
    mono_lib = "lib/net46/System.Reactive.dll",
    core_deps = {
        "netcoreapp2.0": [
            "@system.threading.tasks.extensions//:netcoreapp2.0_core",
        ],
        "netcoreapp2.1": [
            "@system.threading.tasks.extensions//:netcoreapp2.1_core",
        ],
    },
    net_deps = {
        "net46": [
            "@system.threading.tasks.extensions//:net46_net",
            "@system.valuetuple//:net46_net",
        ],
        "net461": [
            "@system.threading.tasks.extensions//:net461_net",
            "@system.valuetuple//:net461_net",
        ],
        "net462": [
            "@system.threading.tasks.extensions//:net462_net",
            "@system.valuetuple//:net462_net",
        ],
        "net47": [
            "@system.threading.tasks.extensions//:net47_net",
            "@system.valuetuple//:net47_net",
        ],
        "net471": [
            "@system.threading.tasks.extensions//:net471_net",
            "@system.valuetuple//:net471_net",
        ],
        "net472": [
            "@system.threading.tasks.extensions//:net472_net",
            "@system.valuetuple//:net472_net",
        ],
        "net48": [
            "@system.threading.tasks.extensions//:net48_net",
            "@system.valuetuple//:net48_net",
        ],
        "netstandard2.0": [
            "@system.threading.tasks.extensions//:netstandard2.0_net",
        ],
        "netstandard2.1": [
            "@system.threading.tasks.extensions//:netstandard2.1_net",
        ],
    },
    mono_deps = [
        "@system.threading.tasks.extensions//:mono",
        "@system.valuetuple//:mono",
    ],
    core_files = {
        "netcoreapp2.0": [
            "lib/netstandard2.0/System.Reactive.dll",
            "lib/netstandard2.0/System.Reactive.xml",
        ],
        "netcoreapp2.1": [
            "lib/netstandard2.0/System.Reactive.dll",
            "lib/netstandard2.0/System.Reactive.xml",
        ],
        "netcoreapp3.0": [
            "build/netcoreapp3.0/System.Reactive.dll",
            "build/netcoreapp3.0/System.Reactive.targets",
            "build/netcoreapp3.0/System.Reactive.xml",
        ],
        "netcoreapp3.1": [
            "build/netcoreapp3.0/System.Reactive.dll",
            "build/netcoreapp3.0/System.Reactive.targets",
            "build/netcoreapp3.0/System.Reactive.xml",
        ],
    },
    net_files = {
        "net46": [
            "lib/net46/System.Reactive.dll",
            "lib/net46/System.Reactive.xml",
        ],
        "net461": [
            "lib/net46/System.Reactive.dll",
            "lib/net46/System.Reactive.xml",
        ],
        "net462": [
            "lib/net46/System.Reactive.dll",
            "lib/net46/System.Reactive.xml",
        ],
        "net47": [
            "lib/net46/System.Reactive.dll",
            "lib/net46/System.Reactive.xml",
        ],
        "net471": [
            "lib/net46/System.Reactive.dll",
            "lib/net46/System.Reactive.xml",
        ],
        "net472": [
            "lib/net46/System.Reactive.dll",
            "lib/net46/System.Reactive.xml",
        ],
        "net48": [
            "lib/net46/System.Reactive.dll",
            "lib/net46/System.Reactive.xml",
        ],
        "netstandard2.0": [
            "lib/netstandard2.0/System.Reactive.dll",
            "lib/netstandard2.0/System.Reactive.xml",
        ],
        "netstandard2.1": [
            "lib/netstandard2.0/System.Reactive.dll",
            "lib/netstandard2.0/System.Reactive.xml",
        ],
    },
    mono_files = [
        "lib/net46/System.Reactive.dll",
        "lib/net46/System.Reactive.xml",
    ],
)
### End of generated by the tool
