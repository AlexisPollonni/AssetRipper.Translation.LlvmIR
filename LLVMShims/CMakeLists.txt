cmake_minimum_required(VERSION 3.20)
project(LLVMShims CXX)

# Standards
set(CMAKE_C_STANDARD 17)
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# For linking static LLVM into our shared lib
set(CMAKE_POSITION_INDEPENDENT_CODE ON)

include(FetchContent)

# --- Configure LLVM Build ---
# Set options for the LLVM subproject. This must be done BEFORE FetchContent_MakeAvailable.
# Using CACHE variables without FORCE is the standard way to set options for a subproject.
#set(LLVM_TARGETS_TO_BUILD "X86" CACHE STRING "Target to build")
set(LLVM_ENABLE_PROJECTS "" CACHE STRING "LLVM projects to build")
set(BUILD_SHARED_LIBS OFF CACHE BOOL "Build shared libraries")
set(LLVM_ENABLE_RTTI ON CACHE BOOL "Enable RTTI")
set(LLVM_ENABLE_EH ON CACHE BOOL "Enable Exceptions")
set(LLVM_INCLUDE_TESTS OFF CACHE BOOL "Include tests")
set(LLVM_INCLUDE_EXAMPLES OFF CACHE BOOL "Include examples")
set(LLVM_INCLUDE_BENCHMARKS OFF CACHE BOOL "Include benchmarks")
set(LLVM_BUILD_TOOLS OFF CACHE BOOL "Build tools")

# --- Fetch and Include LLVM ---
message(STATUS ">> Declaring LLVM FetchContent...")
FetchContent_Declare(
  llvm
  GIT_REPOSITORY https://github.com/llvm/llvm-project.git
  GIT_TAG        "llvmorg-20.1.8" # Pin to a specific stable version
  GIT_SHALLOW    TRUE
  UPDATE_DISCONNECTED TRUE # Prevents checking git remote on every configure
  SOURCE_SUBDIR  llvm
)
message(STATUS ">> Calling FetchContent_MakeAvailable for LLVM. This will take a long time...")
FetchContent_MakeAvailable(llvm)
message(STATUS ">> LLVM FetchContent_MakeAvailable finished.")

# --- Use LLVM in our Project ---
# Get the source and binary directories for LLVM from FetchContent
FetchContent_GetProperties(llvm)
if(NOT llvm_POPULATED)
    message(FATAL_ERROR "LLVM was not populated by FetchContent")
endif()

# Set up LLVM include directories manually using FetchContent paths
set(LLVM_INCLUDE_DIRS 
    ${llvm_SOURCE_DIR}/llvm/include
    ${llvm_BINARY_DIR}/include
)

message(STATUS ">> LLVM include directories: ${LLVM_INCLUDE_DIRS}")

# Use the helper function provided by LLVM to get the library targets.
llvm_map_components_to_libnames(llvm_libs support core irreader demangle)

# --- Build Your Library ---
add_library(LLVMShims SHARED library.cpp)

# LLVM is C++, so we must link with a C++ linker.
set_target_properties(LLVMShims PROPERTIES LINKER_LANGUAGE CXX)

# Add LLVM's include paths to the target
target_include_directories(LLVMShims PRIVATE ${LLVM_INCLUDE_DIRS})

# Add LLVM's required compile definitions to the target
separate_arguments(LLVM_DEFINITIONS_LIST NATIVE_COMMAND ${LLVM_DEFINITIONS})
target_compile_definitions(LLVMShims PRIVATE ${LLVM_DEFINITIONS_LIST})

# Link your library to the required LLVM libraries.
target_link_libraries(LLVMShims PRIVATE ${llvm_libs})