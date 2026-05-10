using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEC2ERKNS_3cpp5arrayItLm1EEE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&)")]
internal static partial class BigInt_16ul_false_unsigned_short_BigInt_cpp_array_unsigned_short_1ul_const
{
	public unsafe static void Invoke(void* @this, void* words)
	{
		unchecked
		{
			llvm_memset_p0_i64.Invoke(&((BigInt_ys7s55*)@this)->val.Data, 0, 2L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&((BigInt_ys7s55*)@this)->val, words, 2L, isVolatile: false);
		}
	}
}
