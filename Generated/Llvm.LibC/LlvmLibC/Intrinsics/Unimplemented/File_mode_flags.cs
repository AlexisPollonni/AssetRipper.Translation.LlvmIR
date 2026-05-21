using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

internal static partial class File_mode_flags
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("_ZN19__llvm_libc_20_1_2_4File10mode_flagsEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::File::mode_flags(char const*)")]
	public unsafe static int Invoke([NativeType("char const*")] void* parameter_0)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: _ZN19__llvm_libc_20_1_2_4File10mode_flagsEPKc");
	}
}
