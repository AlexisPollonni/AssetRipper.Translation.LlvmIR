cmake_minimum_required(VERSION 3.28)

# Prefer Ninja generator: if Ninja is available and not selected, suggest using preset or -G Ninja.
if(NOT CMAKE_GENERATOR STREQUAL "Ninja")
  find_program(_NINJA_EXE NAMES ninja ninja.exe)
  if(_NINJA_EXE)
    message(STATUS "Ninja is available. For faster, incremental builds consider: cmake --preset default (Ninja) or -G Ninja")
  endif()
endif()

# On Windows, increase the max path length for object files to avoid issues with long paths in dependencies
if(WIN32)
    cmake_policy(SET CMP0135 NEW)
    set(CMAKE_OBJECT_PATH_MAX 500)
endif()

project(libLLVMSharp CXX)

include(FetchContent)
include(GenerateExportHeader)


set(CMAKE_CXX_VISIBILITY_PRESET "hidden")
set(CMAKE_VISIBILITY_INLINES_HIDDEN ON)

set(FETCHCONTENT_QUIET FALSE)

set(SOURCES
  LLVMSharp.cpp
  LLVMSharp.h
)

set(LLVM_SEARCH_PATHS
  ${PATH_TO_LLVM}
  ${PATH_TO_LLVM}/lib/cmake
  ${PATH_TO_LLVM}/lib/cmake/llvm
  ${PATH_TO_LLVM}/lib/cmake/clang
  ${PATH_TO_LLVM}/share/clang/cmake/
  ${PATH_TO_LLVM}/share/llvm/cmake/
)

# Minimal LLVM options to reduce build time/size (set as CACHE to apply to subproject)
set(LLVM_INCLUDE_BENCHMARKS OFF CACHE BOOL "")
set(LLVM_INCLUDE_DOCS OFF CACHE BOOL "")
set(LLVM_INCLUDE_EXAMPLES OFF CACHE BOOL "")
set(LLVM_INCLUDE_TESTS OFF CACHE BOOL "")
set(LLVM_INCLUDE_TOOLS OFF CACHE BOOL "")
set(LLVM_INCLUDE_UTILS OFF CACHE BOOL "")
set(LLVM_INCLUDE_GO_TESTS OFF CACHE BOOL "")

set(LLVM_ENABLE_PROJECTS "clang" CACHE STRING "Enabled LLVM projects")
set(LLVM_ENABLE_RUNTIMES "" CACHE STRING "")

set(LLVM_ENABLE_BINDINGS OFF CACHE BOOL "")
set(LLVM_ENABLE_OCAML OFF CACHE BOOL "")
set(LLVM_ENABLE_ZLIB OFF CACHE BOOL "")
set(LLVM_ENABLE_ZSTD OFF CACHE BOOL "")
set(LLVM_ENABLE_TERMINFO OFF CACHE BOOL "")
set(LLVM_ENABLE_LIBXML2 OFF CACHE BOOL "")
set(LLVM_ENABLE_CURL OFF CACHE BOOL "")
set(LLVM_ENABLE_HTTPLIB OFF CACHE BOOL "")
set(LLVM_ENABLE_UNWIND_TABLES OFF CACHE BOOL "")
set(LLVM_ENABLE_GO OFF CACHE BOOL "")



set(BUILD_SHARED_LIBS OFF CACHE BOOL "")

set(LLVM_BUILD_LLVM_DYLIB OFF CACHE BOOL "")
set(LLVM_BUILD_RUNTIME OFF CACHE BOOL "")
set(LLVM_BUILD_EXAMPLES OFF CACHE BOOL "")
set(LLVM_BUILD_TESTS OFF CACHE BOOL "")
set(LLVM_BUILD_BENCHMARKS OFF CACHE BOOL "")
set(LLVM_BUILD_UTILS OFF CACHE BOOL "")

set(LLVM_TARGETS_TO_BUILD "host" CACHE STRING "")


FetchContent_Declare(
  llvm
  GIT_REPOSITORY https://github.com/llvm/llvm-project.git
  GIT_TAG llvmorg-21.1.1
  GIT_PROGRESS TRUE
  GIT_SHALLOW TRUE
  SOURCE_SUBDIR llvm
  EXCLUDE_FROM_ALL TRUE
)
  
FetchContent_MakeAvailable(llvm)
  
# Set Clang source dir, if not present Clang will not be built
set(LLVM_EXTERNAL_CLANG_SOURCE_DIR "${llvm_SOURCE_DIR}/clang" CACHE PATH "")

add_library(LLVMSharp SHARED ${SOURCES})

target_link_libraries(LLVMSharp PRIVATE LLVM-C)
target_link_libraries(LLVMSharp PRIVATE LLVMDemangle)
target_link_libraries(LLVMSharp PRIVATE LLVMAggressiveInstCombine)
target_link_libraries(LLVMSharp PRIVATE LLVMCFGuard)
target_link_libraries(LLVMSharp PRIVATE LLVMInstCombine)
target_link_libraries(LLVMSharp PRIVATE LLVMInstrumentation)
target_link_libraries(LLVMSharp PRIVATE LLVMipo)
target_link_libraries(LLVMSharp PRIVATE LLVMObjCARCOpts)
target_link_libraries(LLVMSharp PRIVATE LLVMScalarOpts)
target_link_libraries(LLVMSharp PRIVATE LLVMTransformUtils)
target_link_libraries(LLVMSharp PRIVATE LLVMVectorize)

llvm_map_components_to_libnames(llvm_libs core support irreader)
target_link_libraries(LLVMSharp PRIVATE ${llvm_libs})

target_include_directories(LLVMSharp PRIVATE ${LLVM_INCLUDE_DIRS} ${CLANG_INCLUDE_DIRS})

set_target_properties(LLVMSharp PROPERTIES
    PREFIX lib
    VERSION ${PROJECT_VERSION}
    SOVERSION ${PROJECT_VERSION}
)

generate_export_header(LLVMSharp
    EXPORT_MACRO_NAME "LLVMSHARP_LINKAGE"
    EXPORT_FILE_NAME LLVMSharp_export.h
)

set_property(TARGET LLVMSharp APPEND PROPERTY
    PUBLIC_HEADER LLVMSharp.h "${CMAKE_CURRENT_BINARY_DIR}/LLVMSharp_export.h"
)

include(GNUInstallDirs)

install(TARGETS LLVMSharp
    LIBRARY DESTINATION ${CMAKE_INSTALL_LIBDIR} COMPONENT runtime
    ARCHIVE DESTINATION ${CMAKE_INSTALL_LIBDIR} COMPONENT development
    RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR} COMPONENT runtime
    PUBLIC_HEADER DESTINATION ${CMAKE_INSTALL_INCLUDEDIR} COMPONENT development
)