using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_or_static_cast_unsigned_int_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp18bit_or_static_castIjlEET_RKT0_")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::cpp::bit_or_static_cast<unsigned int, long>(long const&)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("long const&")] void* from)
	{
		return unchecked((int)(*(long*)from));
	}
}
