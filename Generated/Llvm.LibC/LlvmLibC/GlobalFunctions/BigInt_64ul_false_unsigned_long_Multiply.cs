using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Multiply
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEmlERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator*(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&) const")]
	public unsafe static long Invoke([MangledName("this")] BigInt_555ggs* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* Other)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
		Struct_fiz2nb struct_fiz2nb = BigInt_64ul_false_unsigned_long_ful_mul_64ul.Invoke(This, Other);
		InlineArray2_Int64* ptr = &bigInt_qdkjbh.Val.Data;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			BigInt_64ul_false_unsigned_long_BigInt_128ul_false_unsigned_long.Invoke(&bigInt_555ggs, (Anon_izyfb7*)(&bigInt_qdkjbh));
			Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			return *(long*)(&bigInt_555ggs.Val.Data);
		}
	}
}
