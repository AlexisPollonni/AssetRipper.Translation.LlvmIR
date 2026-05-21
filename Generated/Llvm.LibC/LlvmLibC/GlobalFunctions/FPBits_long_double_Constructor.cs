using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIeEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<long double>::FPBits()")]
	public unsafe static void Invoke(void* @this)
	{
		FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_Constructor.Invoke(@this);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIeEC2IeEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<long double>::FPBits<long double>(long double)")]
	public unsafe static void Invoke(void* @this, [NativeType("long double")] double x)
	{
		Int128 field_ = default(Int128);
		double num = x;
		FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_Constructor.Invoke(@this);
		Struct_fiz2nb struct_fiz2nb = cpp_bit_cast_unsigned_int128_long_double.Invoke(&num);
		Int128* num2 = &field_;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num2 = struct_fiz2nb2.field_0;
			byte* num3 = (byte*)(&field_) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num3 = struct_fiz2nb3.field_1;
			((fputil_internal_FPStorage_w3h7gw*)@this)->field_0 = field_;
		}
	}
}
