using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_EC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::FPBits()")]
	public unsafe static void Invoke(fputil_FPBits_2fahva* @this)
	{
		FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke(unchecked((fputil_internal_FPRepImpl_7z3gh9*)@this));
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_EC2IDF16_EET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::FPBits<_Float16>(_Float16)")]
	public unsafe static void Invoke(fputil_FPBits_2fahva* @this, [NativeType("_Float16")] Half x)
	{
		Half half = x;
		unchecked
		{
			FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke((fputil_internal_FPRepImpl_7z3gh9*)@this);
			((fputil_internal_FPStorage_za9n4f*)@this)->field_0 = cpp_bit_cast_unsigned_short_Float16.Invoke(&half);
		}
	}
}
