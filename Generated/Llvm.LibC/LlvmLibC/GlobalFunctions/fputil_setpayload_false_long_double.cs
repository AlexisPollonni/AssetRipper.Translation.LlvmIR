using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_setpayload_false_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10setpayloadILb0EeEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEbE4typeERS4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, bool>::type __llvm_libc_20_1_2_::fputil::setpayload<false, long double>(long double&, long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, bool>::type")]
	public unsafe static bool Invoke([NativeType("long double&")] void* res, [NativeType("long double")] double pl)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		int num = 0;
		Int128 x = default(Int128);
		Int128 int2 = default(Int128);
		Int128 x2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		bool result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, pl);
			if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi3))
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				sbyte val = anon_izyfb8.val;
				@int = 0L;
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val, *(long*)(&@int), ((long*)(&@int))[1]);
				Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				*(double*)res = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi4);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				result = false;
				goto IL_0326;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent.Invoke(&fputil_FPBits_ubgsi3);
			if (!FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&fputil_FPBits_ubgsi3) && num >= 0 && num < 62)
			{
				Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num2 = &x;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				*(long*)num2 = struct_fiz2nb5.field_0;
				byte* num3 = (byte*)(&x) + 8u;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				*(long*)num3 = struct_fiz2nb6.field_1;
				if (!NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(NumericHelper.ShiftLeft(x, (Int128)(UInt128)(uint)num), long.MaxValue), 0L))
				{
					llvm_lifetime_start_p0.Invoke(16L, &int2);
					Struct_fiz2nb struct_fiz2nb7 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num4 = &x2;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					*(long*)num4 = struct_fiz2nb8.field_0;
					byte* num5 = (byte*)(&x2) + 8u;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					*(long*)num5 = struct_fiz2nb9.field_1;
					int2 = NumericHelper.ShiftRightLogical(x2, (Int128)(UInt128)(uint)checked(63 - num));
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					Int128 int4 = int2;
					sbyte val2 = anon_izyfb9.val;
					int3 = int4;
					Struct_fiz2nb struct_fiz2nb10 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val2, *(long*)(&int3), ((long*)(&int3))[1]);
					Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb11.field_0;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb12.field_1;
					*(double*)res = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi5);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					result = false;
					llvm_lifetime_end_p0.Invoke(16L, &int2);
					goto IL_0314;
				}
			}
			*(double*)res = 0.0;
			result = true;
			goto IL_0314;
		}
		IL_0326:
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
		IL_0314:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		goto IL_0326;
	}
}
