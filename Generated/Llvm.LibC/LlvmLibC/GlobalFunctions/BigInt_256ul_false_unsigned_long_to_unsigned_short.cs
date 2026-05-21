using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_to_unsigned_short
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE2toItEENS_3cpp9enable_ifIXaasr3cppE13is_integral_vIT_Entsr3cppE9is_same_vIS5_bEES5_E4typeEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned short> && !cpp::is_same_v<unsigned short, bool>, unsigned short>::type __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::to<unsigned short>() const")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned short> && !cpp::is_same_v<unsigned short, bool>, unsigned short>::type")]
	public unsafe static short Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_x9dsed* This)
	{
		long num = 0L;
		short num2 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 16L;
		Llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = unchecked((short)(*(long*)Array_unsigned_long_4ul_Index_pwcpnu.Invoke(&This->Val, 0L)));
		short result = num2;
		Llvm_lifetime_end_p0.Invoke(2L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
