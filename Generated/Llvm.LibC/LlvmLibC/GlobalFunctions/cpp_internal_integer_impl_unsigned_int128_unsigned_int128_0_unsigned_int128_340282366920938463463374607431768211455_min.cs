using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8internal12integer_implIoLo0ELo340282366920938463463374607431768211455EE3minEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::internal::integer_impl<unsigned __int128, (unsigned __int128)0, (unsigned __int128)340282366920938463463374607431768211455>::min()")]
internal static partial class cpp_internal_integer_impl_unsigned_int128_unsigned_int128_0_unsigned_int128_340282366920938463463374607431768211455_min
{
	public unsafe static Struct_fiz2nb Invoke()
	{
		Int128 @int = 0L;
		return *unchecked((Struct_fiz2nb*)(&@int));
	}
}
