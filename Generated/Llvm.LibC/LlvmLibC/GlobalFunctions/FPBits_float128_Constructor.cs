using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_float128_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIgEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<__float128>::FPBits()")]
	public unsafe static void Invoke(void* @this)
	{
		FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_Constructor.Invoke(@this);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIgEC2IgEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<__float128>::FPBits<__float128>(__float128)")]
	public unsafe static void Invoke(void* @this, [NativeType("__float128")] double x)
	{
		Int128 field_ = default(Int128);
		double num = x;
		FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_Constructor.Invoke(@this);
		Struct_fiz2nb struct_fiz2nb = cpp_bit_cast_unsigned_int128_float128.Invoke(&num);
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
