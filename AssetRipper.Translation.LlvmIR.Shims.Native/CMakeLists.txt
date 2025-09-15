cmake_minimum_required(VERSION 3.20)

# Standalone FetchContent-based CMake for LLVMShims
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

project(LLVMShims CXX)

# Standards
set(CMAKE_C_STANDARD 17)
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_POSITION_INDEPENDENT_CODE ON)

include(FetchContent)

# FetchContent settings
set(FETCHCONTENT_BASE_DIR "${CMAKE_CURRENT_SOURCE_DIR}/.deps" CACHE PATH "FetchContent base directory")
set(FETCHCONTENT_UPDATES_DISCONNECTED ON CACHE BOOL "" )
set(FETCHCONTENT_QUIET OFF CACHE BOOL "")

# LLVM configuration options (set BEFORE populating)
# Keep LLVM lean (set BEFORE FetchContent_Populate/add_subdirectory)
set(LLVM_ENABLE_PROJECTS "" CACHE STRING "")
set(LLVM_ENABLE_RUNTIMES "" CACHE STRING "")

# Don’t build samples/benchmarks/docs/tests/utils/tools
set(LLVM_INCLUDE_TESTS OFF CACHE BOOL "")
set(LLVM_BUILD_TESTS OFF CACHE BOOL "")
set(LLVM_INCLUDE_EXAMPLES OFF CACHE BOOL "")
set(LLVM_BUILD_EXAMPLES OFF CACHE BOOL "")
set(LLVM_INCLUDE_BENCHMARKS OFF CACHE BOOL "")
set(LLVM_BUILD_BENCHMARKS OFF CACHE BOOL "")
set(LLVM_INCLUDE_DOCS OFF CACHE BOOL "")
set(LLVM_BUILD_DOCS OFF CACHE BOOL "")
set(LLVM_BUILD_UTILS OFF CACHE BOOL "")
set(LLVM_BUILD_TOOLS OFF CACHE BOOL "")

# Disable bindings
set(LLVM_ENABLE_BINDINGS OFF CACHE BOOL "")
set(LLVM_ENABLE_OCAML OFF CACHE BOOL "")
set(LLVM_ENABLE_OCAMLDOC OFF CACHE BOOL "")
set(LLVM_ENABLE_GO OFF CACHE BOOL "")
set(LLVM_INCLUDE_GO_TESTS OFF CACHE BOOL "")

# Turn off optional third-party feature probes
set(LLVM_ENABLE_ZLIB OFF CACHE BOOL "")
set(LLVM_ENABLE_ZSTD OFF CACHE BOOL "")
set(LLVM_ENABLE_LIBXML2 OFF CACHE BOOL "")
set(LLVM_ENABLE_TERMINFO OFF CACHE BOOL "")
set(LLVM_ENABLE_LIBEDIT OFF CACHE BOOL "")
set(LLVM_ENABLE_CURSES OFF CACHE BOOL "")
set(LLVM_ENABLE_CURL OFF CACHE BOOL "")
set(LLVM_ENABLE_Z3_SOLVER OFF CACHE BOOL "")
set(LLVM_ENABLE_BACKTRACES OFF CACHE BOOL "")
set(LLVM_ENABLE_CRASH_OVERRIDES OFF CACHE BOOL "")
set(LLVM_ENABLE_PLUGINS OFF CACHE BOOL "")

# Build/ABI shape
set(BUILD_SHARED_LIBS OFF CACHE BOOL "")
set(LLVM_BUILD_LLVM_C_DYLIB OFF CACHE BOOL "")
set(LLVM_ENABLE_ASSERTIONS OFF CACHE BOOL "")
# If your shims don’t rely on exceptions/RTTI inside LLVM, consider disabling:
# set(LLVM_ENABLE_EH OFF CACHE BOOL "")
# set(LLVM_ENABLE_RTTI OFF CACHE BOOL "")


# Detect host backend name for LLVM
set(_host_backend "")
string(TOLOWER "${CMAKE_SYSTEM_PROCESSOR}" _proc)
if(_proc MATCHES "^(x86_64|amd64|i[3-6]86)$")
  set(_host_backend X86)
elseif(_proc MATCHES "^(aarch64|arm64)$")
  set(_host_backend AArch64)
elseif(_proc MATCHES "^arm")
  set(_host_backend ARM) # 32-bit ARM
endif()
if(_host_backend)
  set(LLVM_TARGETS_TO_BUILD "${_host_backend}" CACHE STRING "LLVM targets to build")
endif()

FetchContent_Declare(
  llvm
  SOURCE_DIR "${CMAKE_CURRENT_LIST_DIR}/llvm-project"
  SOURCE_SUBDIR llvm
)

FetchContent_GetProperties(llvm)
if(NOT llvm_POPULATED)
  FetchContent_Populate(llvm)
  # Add LLVM as a subdirectory but keep it out of the default ALL target
  add_subdirectory(${llvm_SOURCE_DIR}/llvm ${llvm_BINARY_DIR}/llvm EXCLUDE_FROM_ALL)
endif()

# Include directories: LLVM sources and generated headers from the build tree
set(LLVM_INCLUDE_DIRS
  ${llvm_SOURCE_DIR}/llvm/include
  ${llvm_BINARY_DIR}/llvm/include
)

# Create your shims library
add_library(LLVMShims SHARED library.cpp)
set_target_properties(LLVMShims PROPERTIES LINKER_LANGUAGE CXX)

target_include_directories(LLVMShims PRIVATE ${LLVM_INCLUDE_DIRS})

# Prefer component mapping helper when available; fallback to imported targets
if(COMMAND llvm_map_components_to_libnames)
  # Minimal set of components often needed; adjust as required by your code
  llvm_map_components_to_libnames(llvm_libs support core irreader demangle)
  target_link_libraries(LLVMShims PRIVATE ${llvm_libs})
else()
  # Fallback to imported targets if the helper is not available in this context
  target_link_libraries(LLVMShims PRIVATE LLVM::Core LLVM::Support LLVM::IRReader)
endif()

# Notes:
# - To add more LLVM components, include them in llvm_map_components_to_libnames, e.g., "analysis;bitreader".
# - With EXCLUDE_FROM_ALL, building the target LLVMShims will trigger only the needed LLVM libs as dependencies.

install(
  TARGETS LLVMShims
  RUNTIME DESTINATION ${CMAKE_INSTALL_PREFIX}  # .dll/.exe on Windows
  LIBRARY DESTINATION ${CMAKE_INSTALL_PREFIX}  # .so/.dylib on Linux/macOS
  ARCHIVE DESTINATION ${CMAKE_INSTALL_LIBDIR}  # .lib/.a import/static libs
)
