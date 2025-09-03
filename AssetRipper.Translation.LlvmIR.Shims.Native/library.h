#ifndef LLVMSHIMS_LIBRARY_H
#define LLVMSHIMS_LIBRARY_H

// Include the specific LLVM headers you need
#include "llvm/IR/Module.h"

// DLL export macro for P/Invoke compatibility
#ifdef _WIN32
    #define LLVM_SHIMS_API __declspec(dllexport)
#else
    #define LLVM_SHIMS_API __attribute__((visibility("default")))
#endif

// To make the function callable from C, we use extern "C".
extern "C" {

// Function to get the return type of a function
LLVM_SHIMS_API LLVMOpaqueType *FunctionGetReturnType(LLVMOpaqueValue *Fn);

// Function to get the function type of a function
LLVM_SHIMS_API LLVMOpaqueType *FunctionGetFunctionType(LLVMOpaqueValue *Fn);

// Function to get data from a ConstantDataArray
LLVM_SHIMS_API unsigned char *ConstantDataArrayGetData(LLVMOpaqueValue *ConstantDataArray, int *out_size);

// Function to get demangled name of a value
LLVM_SHIMS_API int ValueGetDemangledName(LLVMOpaqueValue *value, unsigned char *buffer, int buffer_size);

// Function to check if instruction has no signed wrap
LLVM_SHIMS_API int InstructionHasNoSignedWrap(LLVMOpaqueValue *instruction);

// Function to check if instruction has no unsigned wrap
LLVM_SHIMS_API int InstructionHasNoUnsignedWrap(LLVMOpaqueValue *instruction);
}

#endif // LLVMSHIMS_LIBRARY_H
