using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_ceil_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_ceilIhEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, unsigned char>::type __llvm_libc_20_1_2_::cpp::bit_ceil<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, unsigned char>::type")]
	public static sbyte Invoke([NativeType("unsigned char")] sbyte value)
	{
		sbyte b = value;
		unchecked
		{
			if ((byte)b < 2)
			{
				return 1;
			}
			return (sbyte)(1 << cpp_bit_width_unsigned_int.Invoke((byte)b - 1));
		}
	}
}
