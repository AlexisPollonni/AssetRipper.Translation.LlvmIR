using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_assume
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.assume")]
	[DemangledName("llvm.assume")]
	public static void Invoke(bool parameter)
	{
		//IL_0009: Expected O, but got I4
		IntrinsicFunctions.DoNothing(parameter);
	}
}
