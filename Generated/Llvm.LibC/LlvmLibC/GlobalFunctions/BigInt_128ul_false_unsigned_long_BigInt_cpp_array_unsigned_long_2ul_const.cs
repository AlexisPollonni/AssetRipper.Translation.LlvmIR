using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEC2ERKNS_3cpp5arrayImLm2EEE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul> const&)")]
internal static partial class BigInt_128ul_false_unsigned_long_BigInt_cpp_array_unsigned_long_2ul_const
{
	public unsafe static void Invoke(anon_izyfb7* @this, cpp_array_i3937k* words)
	{
		unchecked
		{
			llvm_memset_p0_i64.Invoke(&((BigInt_qdkjbh*)@this)->val.Data, 0, 16L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&((BigInt_qdkjbh*)@this)->val, words, 16L, isVolatile: false);
		}
	}
}
