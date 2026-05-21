using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_countl_zero_unsigned_int128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countl_zeroIoEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned __int128>, int>::type __llvm_libc_20_1_2_::cpp::countl_zero<unsigned __int128>(unsigned __int128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned __int128>, int>::type")]
	public unsafe static int Invoke([MangledName("value.coerce0")] long Value, [MangledName("value.coerce1")][NativeType("unsigned __int128")] long Value_coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = Value;
			((long*)(&@int))[1] = Value_coerce1;
			Int128 int2 = @int;
			return InstructionHelper.Select(falseValue: (int)Llvm_ctlz_i128.Invoke(int2, parameter_1: true), condition: NumericHelper.IntCmpEq(int2, 0L), trueValue: 128);
		}
	}
}
