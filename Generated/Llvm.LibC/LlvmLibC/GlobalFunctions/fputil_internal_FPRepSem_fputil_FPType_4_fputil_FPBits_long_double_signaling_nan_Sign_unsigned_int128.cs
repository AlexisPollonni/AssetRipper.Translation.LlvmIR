using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE13signaling_nanENS_4SignEo")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::signaling_nan(__llvm_libc_20_1_2_::Sign, unsigned __int128)")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_signaling_nan_Sign_unsigned_int128
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("sign.coerce")] sbyte sign, [MangledName("v.coerce0")] long v, [MangledName("v.coerce1")] long v_coerce1)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua3 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua4 = default(fputil_internal_FPRepSem_f94eua);
		Int128 int2 = default(Int128);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua5 = default(fputil_internal_FPRepSem_f94eua);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		anon_izyfb8.val = sign;
		unchecked
		{
			*(long*)(&@int) = v;
			((long*)(&@int))[1] = v_coerce1;
			Int128 int5 = @int;
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
			int field_ = fputil_internal_FPStorage_fputil_FPType_4_Exponent_inf.Invoke();
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = field_;
			fputil_internal_FPStorage_fputil_FPType_4_BiasedExponent_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_4_Exponent.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0);
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_4_Significand_msb.Invoke();
			Int128* ptr = &fputil_internal_FPRepSem_f94eua3.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			if (NumericHelper.IntCmpNe(int5, 0L))
			{
				int2 = int5;
				fputil_internal_FPStorage_fputil_FPType_4_Significand_Significand_unsigned_int128.Invoke(&fputil_internal_FPRepSem_f94eua4, *(long*)(&int2), ((long*)(&int2))[1]);
			}
			else
			{
				Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPStorage_fputil_FPType_4_Significand_msb.Invoke();
				Int128* ptr2 = &fputil_internal_FPRepSem_f94eua5.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
				Struct_fiz2nb struct_fiz2nb7 = fputil_internal_operator_fputil_internal_FPStorage_fputil_FPType_4_Significand_int.Invoke(*(long*)(&fputil_internal_FPRepSem_f94eua5), ((long*)(&fputil_internal_FPRepSem_f94eua5))[1], 2);
				Int128* ptr3 = &fputil_internal_FPRepSem_f94eua4.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
			}
			Struct_fiz2nb struct_fiz2nb10 = fputil_internal_operator_fputil_internal_FPStorage_fputil_FPType_4_Significand_fputil_internal_FPStorage_fputil_FPType_4_Significand_cj4afz.Invoke(*(long*)(&fputil_internal_FPRepSem_f94eua3), ((long*)(&fputil_internal_FPRepSem_f94eua3))[1], *(long*)(&fputil_internal_FPRepSem_f94eua4), ((long*)(&fputil_internal_FPRepSem_f94eua4))[1]);
			Int128* ptr4 = &fputil_internal_FPRepSem_f94eua2.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb11.field_0;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb12.field_1;
			Struct_fiz2nb struct_fiz2nb13 = fputil_internal_FPStorage_fputil_FPType_4_encode_Sign_fputil_internal_FPStorage_fputil_FPType_4_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_4_Significand.Invoke(anon_izyfb9.val, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua2), ((long*)(&fputil_internal_FPRepSem_f94eua2))[1]);
			Int128* num = &int3;
			Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
			*(long*)num = struct_fiz2nb14.field_0;
			byte* num2 = (byte*)(&int3) + 8u;
			Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
			*(long*)num2 = struct_fiz2nb15.field_1;
			int4 = int3;
			fputil_FPBits_long_double_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int4), ((long*)(&int4))[1]);
			return *(Struct_fiz2nb*)(&fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0);
		}
	}
}
