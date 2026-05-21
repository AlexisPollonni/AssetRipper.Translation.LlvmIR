using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_low64
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal5low64ERKo")]
	[DemangledName("__llvm_libc_20_1_2_::internal::low64(unsigned __int128 const&)")]
	public unsafe static long Invoke([NativeType("unsigned __int128 const&")] void* num)
	{
		return unchecked((long)NumericHelper.BitwiseAnd(*(Int128*)num, -1L));
	}
}
