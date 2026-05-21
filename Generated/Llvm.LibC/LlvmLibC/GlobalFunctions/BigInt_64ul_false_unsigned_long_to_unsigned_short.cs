using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_to_unsigned_short
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE2toItEENS_3cpp9enable_ifIXaasr3cppE13is_integral_vIT_Entsr3cppE9is_same_vIS5_bEES5_E4typeEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned short> && !cpp::is_same_v<unsigned short, bool>, unsigned short>::type __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::to<unsigned short>() const")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned short> && !cpp::is_same_v<unsigned short, bool>, unsigned short>::type")]
	public unsafe static short Invoke(BigInt_555ggs* @this)
	{
		long num = 0L;
		short num2 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 16L;
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = unchecked((short)(*(long*)array_unsigned_long_1ul_Index_fk3nam.Invoke(&@this->val, 0L)));
		short result = num2;
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
