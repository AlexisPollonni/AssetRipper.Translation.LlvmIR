using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIeEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<long double>::FPBits()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_Constructor.Invoke(This);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIeEC2IeEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<long double>::FPBits<long double>(long double)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("x")][NativeType("long double")] double X)
	{
		Int128 field_ = default(Int128);
		double num = X;
		FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_Constructor.Invoke(This);
		Struct_fiz2nb struct_fiz2nb = Cpp_bit_cast_unsigned_int128_long_double.Invoke(&num);
		Int128* num2 = &field_;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num2 = struct_fiz2nb2.field_0;
			byte* num3 = (byte*)(&field_) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num3 = struct_fiz2nb3.field_1;
			((Llvm_libc_20_1_2_fputil_internal_FPStorage_w3h7gw*)This)->field_0 = field_;
		}
	}
}
