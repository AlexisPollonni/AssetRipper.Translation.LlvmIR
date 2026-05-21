using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_ceil_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_ceilItEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type __llvm_libc_20_1_2_::cpp::bit_ceil<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type")]
	public static short Invoke([MangledName("value")][NativeType("unsigned short")] short Value)
	{
		short num = Value;
		unchecked
		{
			if ((ushort)num < 2)
			{
				return 1;
			}
			return (short)(1 << Cpp_bit_width_unsigned_int.Invoke((ushort)num - 1));
		}
	}
}
