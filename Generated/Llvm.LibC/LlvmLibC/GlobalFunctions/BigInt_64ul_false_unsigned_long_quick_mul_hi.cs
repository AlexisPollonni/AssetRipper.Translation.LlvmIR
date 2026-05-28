using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_quick_mul_hi
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE12quick_mul_hiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::quick_mul_hi(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&) const")]
	public unsafe static long Invoke([MangledName("this")] BigInt_555ggs* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* Other)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		unchecked
		{
			*(long*)(&bigInt_555ggs) = -6148914691236517206L;
			BigInt_64ul_false_unsigned_long_Constructor.Invoke(&bigInt_555ggs);
			Multiword_quick_mul_hi_unsigned_long_1ul.Invoke(&bigInt_555ggs.Val, &This->Val, &Other->Val);
			return *(long*)(&bigInt_555ggs.Val.Data);
		}
	}
}
