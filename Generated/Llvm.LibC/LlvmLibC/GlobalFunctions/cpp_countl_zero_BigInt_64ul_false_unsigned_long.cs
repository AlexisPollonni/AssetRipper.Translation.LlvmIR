using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_countl_zero_BigInt_64ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countl_zeroINS_6BigIntILm64ELb0EmEEEENS0_9enable_ifIX12is_big_int_vIT_EEiE4typeERKS5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_big_int_v<__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>>, int>::type __llvm_libc_20_1_2_::cpp::countl_zero<__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>>(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<is_big_int_v<__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>>, int>::type")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* value)
	{
		return multiword_countl_zero_unsigned_long_1ul.Invoke(&value->val);
	}
}
