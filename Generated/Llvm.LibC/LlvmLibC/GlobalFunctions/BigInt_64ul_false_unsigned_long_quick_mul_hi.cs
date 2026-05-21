using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_quick_mul_hi
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE12quick_mul_hiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::quick_mul_hi(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&) const")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_555ggs* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_555ggs* Other)
	{
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_BigInt_555ggs) = -6148914691236517206L;
			BigInt_64ul_false_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_555ggs);
			Multiword_quick_mul_hi_unsigned_long_1ul.Invoke(&llvm_libc_20_1_2_BigInt_555ggs.Val, &This->Val, &Other->Val);
			return *(long*)(&llvm_libc_20_1_2_BigInt_555ggs.Val.Data);
		}
	}
}
