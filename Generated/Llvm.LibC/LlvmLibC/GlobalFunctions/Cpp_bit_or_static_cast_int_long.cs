using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_or_static_cast_int_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp18bit_or_static_castIilEET_RKT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::cpp::bit_or_static_cast<int, long>(long const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("from")][NativeType("long const&")] void* From)
	{
		return unchecked((int)(*(long*)From));
	}
}
