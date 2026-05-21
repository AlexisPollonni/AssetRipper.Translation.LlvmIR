using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

internal static partial class File_seek
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("_ZN19__llvm_libc_20_1_2_4File4seekEli")]
	[DemangledName("__llvm_libc_20_1_2_::File::seek(long, int)")]
	public unsafe static long Invoke(void* parameter_0, [NativeType("long")] long parameter_1, [NativeType("int")] int parameter_2)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: _ZN19__llvm_libc_20_1_2_4File4seekEli");
	}
}
