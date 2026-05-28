using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_make_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE10make_valueEoi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::make_value(unsigned __int128, int)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("number.coerce0")] long Number, [MangledName("number.coerce1")][NativeType("unsigned __int128")] long Ep, [MangledName("ep")][NativeType("int")] int Result)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		Fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud = default(Fputil_internal_FPRepImpl_jrxud9);
		int num = 0;
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		Int128 int9;
		Int128 int7;
		int num2;
		unchecked
		{
			*(long*)(&@int) = Number;
			((long*)(&@int))[1] = Ep;
			int7 = @int;
			num2 = Result;
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_internal_FPRepImpl_jrxud);
			*(Int128*)(&fputil_internal_FPRepImpl_jrxud) = -6148914691236517206L;
			Int128 int8 = 0L;
			FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_Constructor.Invoke(&fputil_internal_FPRepImpl_jrxud, *(long*)(&int8), ((long*)(&int8))[1]);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			int9 = int7;
		}
		num = 64 - (128 - unchecked(Cpp_countl_zero_unsigned_int128.Invoke(*(long*)(&int9), ((long*)(&int9))[1])));
		int7 = NumericHelper.ShiftLeft(int7, unchecked((Int128)(UInt128)(uint)num));
		num2 -= num;
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke(num2 >= 0, Expected: true))
			{
				int2 = int7;
				FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_significand.Invoke(&fputil_internal_FPRepImpl_jrxud, *(long*)(&int2), ((long*)(&int2))[1]);
				int3 = checked(num2 + 1);
				FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&fputil_internal_FPRepImpl_jrxud, *(long*)(&int3), ((long*)(&int3))[1]);
			}
			else
			{
				int4 = NumericHelper.ShiftRightLogical(int7, (Int128)(UInt128)(uint)checked(-num2));
				FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_significand.Invoke(&fputil_internal_FPRepImpl_jrxud, *(long*)(&int4), ((long*)(&int4))[1]);
			}
			Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&fputil_internal_FPRepImpl_jrxud);
			Int128* num3 = &int5;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num3 = struct_fiz2nb2.field_0;
			byte* num4 = (byte*)(&int5) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num4 = struct_fiz2nb3.field_1;
			int6 = int5;
			FPBits_long_double_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi, *(long*)(&int6), ((long*)(&int6))[1]);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_internal_FPRepImpl_jrxud);
			return *(Struct_fiz2nb*)(&fputil_FPBits_ubgsi.Val.Data.FPStorage.field_0);
		}
	}
}
