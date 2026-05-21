using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_countr_zero_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countr_zeroIhEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::cpp::countr_zero<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned char")] sbyte Value)
	{
		sbyte b = Value;
		return InstructionHelper.Select(b == 0, 8, unchecked((byte)Llvm_cttz_i8.Invoke(b, parameter_1: true)));
	}
}
