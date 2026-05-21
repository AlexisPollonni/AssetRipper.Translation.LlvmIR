using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_countl_one_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp10countl_oneItEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type __llvm_libc_20_1_2_::cpp::countl_one<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned short")] short Value)
	{
		return Cpp_countl_zero_unsigned_short.Invoke(unchecked((short)((ushort)Value ^ -1)));
	}
}
