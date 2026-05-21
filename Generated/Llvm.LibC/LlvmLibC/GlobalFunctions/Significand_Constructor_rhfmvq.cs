using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_Constructor_rhfmvq
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE11SignificandCI2NS4_8TypedIntIoEEEo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand::Significand(unsigned __int128)")]
	[CleanName("Significand_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName(".coerce0")] long Coerce0, [MangledName(".coerce1")] long Coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = Coerce0;
			((long*)(&@int))[1] = Coerce1;
			Int128 int2 = @int;
			TypedInt_unsigned_int128_Constructor_776834.Invoke(This, *(long*)(&int2), ((long*)(&int2))[1]);
		}
	}
}
