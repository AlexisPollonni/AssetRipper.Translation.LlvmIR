using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_EC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::FPBits()")]
	public unsafe static void Invoke([MangledName("this")] Fputil_FPBits_2fahva* This)
	{
		FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke(unchecked((Fputil_internal_FPRepImpl_7z3gh9*)This));
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_EC2IDF16_EET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::FPBits<_Float16>(_Float16)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_FPBits_2fahva* This, [MangledName("x")][NativeType("_Float16")] Half X)
	{
		Half half = X;
		unchecked
		{
			FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)This);
			((Fputil_internal_FPStorage_za9n4f*)This)->field_0 = Cpp_bit_cast_unsigned_short_Float16.Invoke(&half);
		}
	}
}
