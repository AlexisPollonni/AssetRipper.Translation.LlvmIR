using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_quick_mul_64ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9quick_mulILm64EEENS0_11DyadicFloatIXT_EEERKS3_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul> __llvm_libc_20_1_2_::fputil::quick_mul<64ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<64ul> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_syracv* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_syracv* B)
	{
		Llvm_libc_20_1_2_fputil_DyadicFloat_syracv llvm_libc_20_1_2_fputil_DyadicFloat_syracv = default(Llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs2 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		unchecked
		{
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv) = -86;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv))[1] = -1431655766;
			((long*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv))[1] = -6148914691236517206L;
			DyadicFloat_64ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &A->Sign, 1L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &B->Sign, 1L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(source: (!Llvm_libc_20_1_2_NotEquals_rpctvi.Invoke(anon_izyfb.Val, anon_izyfb2.Val)) ? Llvm_libc_20_1_2_Sign_POS.Pointer : Llvm_libc_20_1_2_Sign_NEG.Pointer, destination: &llvm_libc_20_1_2_fputil_DyadicFloat_syracv.Sign, length: 1L, isVolatile: false);
			llvm_libc_20_1_2_fputil_DyadicFloat_syracv.Exponent = checked(A->Exponent + B->Exponent + 64);
			if (!BigInt_64ul_false_unsigned_long_is_zero.Invoke(&A->Mantissa) && !BigInt_64ul_false_unsigned_long_is_zero.Invoke(&B->Mantissa))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
				long data = BigInt_64ul_false_unsigned_long_quick_mul_hi.Invoke(&A->Mantissa, &B->Mantissa);
				*(long*)(&llvm_libc_20_1_2_BigInt_555ggs.Val.Data) = data;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv.Mantissa, &llvm_libc_20_1_2_BigInt_555ggs, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
				if (*(long*)Array_unsigned_long_1ul_Index_3erz3i.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv.Mantissa.Val, 0L) >>> 63 == 0L)
				{
					DyadicFloat_64ul_shift_left.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv, 1);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
				BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, 0);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv.Mantissa, &llvm_libc_20_1_2_BigInt_555ggs2, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
			}
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
		}
	}
}
