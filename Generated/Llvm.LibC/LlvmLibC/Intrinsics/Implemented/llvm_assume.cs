using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.assume")]
[DemangledName("llvm.assume")]
internal static partial class llvm_assume
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Invoke(bool parameter)
	{
		//IL_0009: Expected O, but got I4
		IntrinsicFunctions.DoNothing(parameter);
	}
}
