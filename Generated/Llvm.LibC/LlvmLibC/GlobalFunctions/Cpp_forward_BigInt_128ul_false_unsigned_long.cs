using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_forward_BigInt_128ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardINS_6BigIntILm128ELb0EmEEEEOT_RNS0_16remove_referenceIS4_E4typeE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&& __llvm_libc_20_1_2_::cpp::forward<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>(__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>::type&)")]
	[return: NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&&")]
	public unsafe static Anon_izyfb7* Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>::type&")] Anon_izyfb7* Value)
	{
		return Value;
	}
}
