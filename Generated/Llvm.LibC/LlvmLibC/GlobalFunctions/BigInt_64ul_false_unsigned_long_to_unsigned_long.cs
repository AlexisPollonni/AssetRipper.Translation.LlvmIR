using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_to_unsigned_long
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE2toImEENS_3cpp9enable_ifIXaasr3cppE13is_integral_vIT_Entsr3cppE9is_same_vIS5_bEES5_E4typeEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned long> && !cpp::is_same_v<unsigned long, bool>, unsigned long>::type __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::to<unsigned long>() const")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned long> && !cpp::is_same_v<unsigned long, bool>, unsigned long>::type")]
	public unsafe static long Invoke([MangledName("this")] BigInt_555ggs* This)
	{
		long num = 0L;
		long num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 64L;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = *unchecked((long*)Array_unsigned_long_1ul_Index_fk3nam.Invoke(&This->Val, 0L));
		long result = num2;
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
