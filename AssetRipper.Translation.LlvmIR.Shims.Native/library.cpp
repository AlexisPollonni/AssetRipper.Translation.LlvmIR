#include "library.h"

#include "llvm/Demangle/Demangle.h"
#include "llvm/IR/Constants.h"
#include "llvm/IR/Operator.h"

using namespace llvm;


LLVMOpaqueType* FunctionGetReturnType(LLVMOpaqueValue* Fn) {
    if (!Fn) return nullptr;

    const auto* func = reinterpret_cast<Function*>(Fn);
    Type* returnType = func->getReturnType();
    return reinterpret_cast<LLVMOpaqueType*>(returnType);
}

LLVMOpaqueType* FunctionGetFunctionType(LLVMOpaqueValue* Fn) {
    if (!Fn) return nullptr;

    const auto func = reinterpret_cast<Function*>(Fn);
    FunctionType* funcType = func->getFunctionType();
    return reinterpret_cast<LLVMOpaqueType*>(funcType);
}

unsigned char* ConstantDataArrayGetData(LLVMOpaqueValue* constantDataArray, int* out_size) {
    if (!constantDataArray || !out_size) {
        if (out_size) *out_size = 0;
        return nullptr;
    }

    const auto* cda = reinterpret_cast<ConstantDataArray*>(constantDataArray);
    const StringRef data = cda->getAsString();

    *out_size = static_cast<int>(data.size());

    // Note: This returns a pointer to internal data. 
    // The caller must not modify or free this data.
    return reinterpret_cast<unsigned char*>(const_cast<char*>(data.data()));
}

int ValueGetDemangledName(LLVMOpaqueValue* value, unsigned char* buffer, int buffer_size) {
    if (!value || !buffer || buffer_size <= 0) {
        return -1;
    }

    const auto val = reinterpret_cast<Value*>(value);

    // Try to get the name of the value
    const StringRef name = val->getName();
    if (name.empty()) {
        return -1; // No name available
    }

    // Attempt to demangle the name
    const std::string demangled = demangle(name.str());

    // If demangling didn't change the name, use the original
    const std::string& finalName = (demangled == name.str()) ? name.str() : demangled;

    const int nameLength = static_cast<int>(finalName.length());

    // Check if buffer is large enough (including null terminator)
    if (buffer_size < nameLength + 1) {
        return nameLength + 1; // Return required buffer size
    }

    // Copy the name to the buffer
    std::memcpy(buffer, finalName.c_str(), nameLength + 1);

    return nameLength; // Return actual length written (without null terminator)
}

int InstructionHasNoSignedWrap(LLVMOpaqueValue* instruction) {
    if (!instruction) return 0;

    auto* inst = reinterpret_cast<Instruction*>(instruction);

    // Check if this is an OverflowingBinaryOperator
    if (const auto* obo = dyn_cast<OverflowingBinaryOperator>(inst)) {
        return obo->hasNoSignedWrap() ? 1 : 0;
    }

    return 0; // Not an overflowing binary operator
}

int InstructionHasNoUnsignedWrap(LLVMOpaqueValue* instruction) {
    if (!instruction) return 0;

    auto* inst = reinterpret_cast<Instruction*>(instruction);

    // Check if this is an OverflowingBinaryOperator
    if (const auto* obo = dyn_cast<OverflowingBinaryOperator>(inst)) {
        return obo->hasNoUnsignedWrap() ? 1 : 0;
    }

    return 0; // Not an overflowing binary operator
}