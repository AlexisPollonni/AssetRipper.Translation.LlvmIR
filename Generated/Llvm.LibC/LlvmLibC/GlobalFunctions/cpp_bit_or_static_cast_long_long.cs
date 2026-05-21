using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_or_static_cast_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp18bit_or_static_castIllEET_RKT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::cpp::bit_or_static_cast<long, long>(long const&)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([NativeType("long const&")] void* from)
	{
		return cpp_bit_cast_long_long.Invoke(from);
	}
}
