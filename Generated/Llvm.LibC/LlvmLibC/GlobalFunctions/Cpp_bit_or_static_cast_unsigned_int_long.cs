using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_or_static_cast_unsigned_int_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp18bit_or_static_castIjlEET_RKT0_")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::cpp::bit_or_static_cast<unsigned int, long>(long const&)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([MangledName("from")][NativeType("long const&")] void* From)
	{
		return unchecked((int)(*(long*)From));
	}
}
