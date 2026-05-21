using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_Constructor_j3ersh
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE11SignificandCI2NS4_8TypedIntIoEEEo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::Significand::Significand(unsigned __int128)")]
	[CleanName("Significand_Constructor")]
	public unsafe static void Invoke(void* @this, [MangledName(".coerce0")] long coerce0, [MangledName(".coerce1")] long coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = coerce0;
			((long*)(&@int))[1] = coerce1;
			Int128 int2 = @int;
			TypedInt_unsigned_int128_Constructor_fuuwmg.Invoke(@this, *(long*)(&int2), ((long*)(&int2))[1]);
		}
	}
}
