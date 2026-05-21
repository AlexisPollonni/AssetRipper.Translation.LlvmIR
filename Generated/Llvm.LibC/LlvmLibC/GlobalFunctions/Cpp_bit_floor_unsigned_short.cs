using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_floor_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_floorItEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type __llvm_libc_20_1_2_::cpp::bit_floor<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type")]
	public static short Invoke([MangledName("value")][NativeType("unsigned short")] short Value)
	{
		short num = Value;
		if (num == 0)
		{
			return 0;
		}
		unchecked
		{
			return (short)(1 << checked(Cpp_bit_width_unsigned_short.Invoke(num) - 1));
		}
	}
}
