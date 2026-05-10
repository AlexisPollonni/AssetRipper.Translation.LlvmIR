using System;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE11SignificandCI2NS4_8TypedIntIoEEEo")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand::Significand(unsigned __int128)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_3_Significand_Significand_unsigned_int128
{
	public unsafe static void Invoke(void* @this, [MangledName(".coerce0")] long coerce0, [MangledName(".coerce1")] long coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = coerce0;
			((long*)(&@int))[1] = coerce1;
			Int128 int2 = @int;
			fputil_internal_FPStorage_fputil_FPType_3_TypedInt_unsigned_int128_TypedInt_unsigned_int128.Invoke(@this, *(long*)(&int2), ((long*)(&int2))[1]);
		}
	}
}
