using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

internal static partial class printf_core_convert
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core7convertEPNS0_6WriterERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::convert(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] void* parameter_0, [NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] void* parameter_1)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: _ZN19__llvm_libc_20_1_2_11printf_core7convertEPNS0_6WriterERKNS0_13FormatSectionE");
	}
}
