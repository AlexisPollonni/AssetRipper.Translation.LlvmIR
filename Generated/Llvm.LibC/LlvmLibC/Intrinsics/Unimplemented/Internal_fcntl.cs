using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

internal static partial class Internal_fcntl
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal5fcntlEiiPv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::fcntl(int, int, void*)")]
	public unsafe static int Invoke([NativeType("int")] int parameter_0, [NativeType("int")] int parameter_1, [NativeType("void*")] void* parameter_2)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: _ZN19__llvm_libc_20_1_2_8internal5fcntlEiiPv");
	}
}
