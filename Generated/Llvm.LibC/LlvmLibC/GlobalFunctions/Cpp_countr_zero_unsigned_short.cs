using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_countr_zero_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countr_zeroItEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type __llvm_libc_20_1_2_::cpp::countr_zero<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned short")] short Value)
	{
		short num = Value;
		return InstructionHelper.Select(num == 0, 16, unchecked((ushort)Llvm_cttz_i16.Invoke(num, parameter_1: true)));
	}
}
