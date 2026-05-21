using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_high64
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6high64ERKo")]
	[DemangledName("__llvm_libc_20_1_2_::internal::high64(unsigned __int128 const&)")]
	public unsafe static long Invoke([NativeType("unsigned __int128 const&")] void* num)
	{
		return unchecked((long)NumericHelper.ShiftRightLogical(*(Int128*)num, 64L));
	}
}
