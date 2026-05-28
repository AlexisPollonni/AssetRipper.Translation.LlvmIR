using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_quick_mul_128ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9quick_mulILm128EEENS0_11DyadicFloatIXT_EEERKS3_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> __llvm_libc_20_1_2_::fputil::quick_mul<128ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* B)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		unchecked
		{
			*(sbyte*)Agg_result = -86;
			sbyte* ptr = (sbyte*)Agg_result + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)Agg_result)[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)Agg_result + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			DyadicFloat_128ul_Constructor.Invoke(Agg_result);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &A->Sign, 1L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &B->Sign, 1L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(source: (!NotEquals_rpctvi.Invoke(anon_izyfb.Val, anon_izyfb2.Val)) ? Sign_POS.Pointer : Sign_NEG.Pointer, destination: &Agg_result->Sign, length: 1L, isVolatile: false);
			Agg_result->Exponent = checked(A->Exponent + B->Exponent + 128);
			if (!BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&A->Mantissa)) && !BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&B->Mantissa)))
			{
				Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
				Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_quick_mul_hi.Invoke((Anon_izyfb7*)(&A->Mantissa), (Anon_izyfb7*)(&B->Mantissa));
				InlineArray2_Int64* ptr3 = &bigInt_qdkjbh.Val.Data;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb3.field_1;
				Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Mantissa, &bigInt_qdkjbh, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
				if (*(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(&Agg_result->Mantissa.Val, 1L) >>> 63 == 0L)
				{
					DyadicFloat_128ul_shift_left.Invoke(Agg_result, 1);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
				BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh2), 0);
				Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Mantissa, &bigInt_qdkjbh2, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
			}
		}
	}
}
