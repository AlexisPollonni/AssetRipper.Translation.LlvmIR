using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEmlERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator*(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&) const")]
[CleanName("BigInt_64ul_false_unsigned_long_operator_BigInt_64ul_false_unsigned_long_const_const")]
internal static partial class BigInt_64ul_false_unsigned_long_operator_BigInt_64ul_false_unsigned_long_const_const_3tyjsr
{
	public unsafe static long Invoke(BigInt_555ggs* @this, BigInt_555ggs* other)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
		Struct_fiz2nb struct_fiz2nb = auto_BigInt_64ul_false_unsigned_long_ful_mul_64ul_BigInt_64ul_false_unsigned_long_const_const.Invoke(@this, other);
		InlineArray2_Int64* ptr = &bigInt_qdkjbh.val.Data;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			BigInt_64ul_false_unsigned_long_BigInt_128ul_false_unsigned_long_BigInt_128ul_false_unsigned_long_const.Invoke(&bigInt_555ggs, (anon_izyfb7*)(&bigInt_qdkjbh));
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			return *(long*)(&bigInt_555ggs.val.Data);
		}
	}
}
