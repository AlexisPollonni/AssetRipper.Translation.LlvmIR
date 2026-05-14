using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.umul.fix.i32")]
[DemangledName("llvm.umul.fix.i32")]
internal static partial class llvm_umul_fix_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke(int a, int b, int scale)
	{
		return IntrinsicFunctions.llvm_umul_fix_i32(a, b, scale);
	}
}
