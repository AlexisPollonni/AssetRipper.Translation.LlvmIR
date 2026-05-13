using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("_ZN19__llvm_libc_20_1_2_4File4seekEli")]
[DemangledName("__llvm_libc_20_1_2_::File::seek(long, int)")]
internal static partial class File_seek_long_int
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static long Invoke(void* parameter_0, long parameter_1, int parameter_2)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: _ZN19__llvm_libc_20_1_2_4File4seekEli");
	}
}
