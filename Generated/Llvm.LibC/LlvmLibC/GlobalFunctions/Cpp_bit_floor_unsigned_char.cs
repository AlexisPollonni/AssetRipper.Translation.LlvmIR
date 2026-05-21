using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_floor_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_floorIhEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, unsigned char>::type __llvm_libc_20_1_2_::cpp::bit_floor<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, unsigned char>::type")]
	public static sbyte Invoke([MangledName("value")][NativeType("unsigned char")] sbyte Value)
	{
		sbyte b = Value;
		if (b == 0)
		{
			return 0;
		}
		unchecked
		{
			return (sbyte)(1 << checked(Cpp_bit_width_unsigned_char.Invoke(b) - 1));
		}
	}
}
