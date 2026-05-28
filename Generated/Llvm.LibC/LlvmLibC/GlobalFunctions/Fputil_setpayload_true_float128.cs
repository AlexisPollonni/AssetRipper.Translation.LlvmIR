using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_setpayload_true_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10setpayloadILb1EgEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEbE4typeERS4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, bool>::type __llvm_libc_20_1_2_::fputil::setpayload<true, __float128>(__float128&, __float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, bool>::type")]
	public unsafe static bool Invoke([MangledName("res")][NativeType("__float128&")] void* Res, [MangledName("pl")][NativeType("__float128")] double Pl)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		int num = 0;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		Int128 x2 = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 int2 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		bool result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi, Pl);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_exponent.Invoke(&fputil_FPBits_ubgsi);
			if (!FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg.Invoke(&fputil_FPBits_ubgsi) && num >= 0 && num < 111)
			{
				Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi);
				Int128* num2 = &x;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&x) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				if (!NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(NumericHelper.ShiftLeft(x, (Int128)(UInt128)(uint)num), -1L), 0L))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi));
					Int128* num4 = &x2;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num4 = struct_fiz2nb5.field_0;
					byte* num5 = (byte*)(&x2) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num5 = struct_fiz2nb6.field_1;
					@int = NumericHelper.ShiftRightLogical(x2, (Int128)(UInt128)(uint)checked(112 - num));
					Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					Int128 int3 = @int;
					sbyte val = anon_izyfb.Val;
					int2 = int3;
					Struct_fiz2nb struct_fiz2nb7 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_signaling_nan.Invoke(val, *(long*)(&int2), ((long*)(&int2))[1]);
					Int128* ptr = &fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb8.field_0;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb9.field_1;
					*(double*)Res = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi2);
					Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
					result = false;
					Llvm_lifetime_end_p0.Invoke(16L, &@int);
					goto IL_0234;
				}
			}
			*(double*)Res = 0.0;
			result = true;
			goto IL_0234;
		}
		IL_0234:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		return result;
	}
}
