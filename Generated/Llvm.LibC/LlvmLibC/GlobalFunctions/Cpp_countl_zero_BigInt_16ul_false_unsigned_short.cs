using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_countl_zero_BigInt_16ul_false_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countl_zeroINS_6BigIntILm16ELb0EtEEEENS0_9enable_ifIX12is_big_int_vIT_EEiE4typeERKS5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_big_int_v<__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>>, int>::type __llvm_libc_20_1_2_::cpp::countl_zero<__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>>(__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<is_big_int_v<__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>>, int>::type")]
	public unsafe static int Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&")] BigInt_ys7s55* Value)
	{
		return Multiword_countl_zero_unsigned_short_1ul.Invoke(&Value->Val);
	}
}
