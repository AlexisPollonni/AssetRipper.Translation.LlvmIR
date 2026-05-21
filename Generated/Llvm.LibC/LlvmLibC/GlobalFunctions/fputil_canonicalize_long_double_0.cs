using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_canonicalize_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<long double, 0>(long double&, long double const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("long double&")] void* cx, [NativeType("long double const&")] void* x)
	{
		int result = 0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		sbyte b = 0;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		sbyte b2 = 0;
		int num = 0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Int128 int4 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		Int128 int5 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		Int128 int6 = default(Int128);
		Int128 int7 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(fputil_FPBits_ubgsi2);
		Int128 int8 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi9 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		Int128 int9 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi10 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		Int128 int10 = default(Int128);
		Int128 int11 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		int num4;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, *(double*)x);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit.Invoke(&fputil_FPBits_ubgsi3) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(16L, &@int);
			Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi3);
			Int128* num2 = &int2;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb2.field_0;
			byte* num3 = (byte*)(&int2) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num3 = struct_fiz2nb3.field_1;
			@int = int2;
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = (NumericHelper.IntCmpNe(NumericHelper.ShiftRightLogical(NumericHelper.BitwiseAnd(@int, 4611686018427387904L), 62L), 0L) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = (ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi3);
			if (num == 32767)
			{
				if ((b & 1) != 1 && (b2 & 1) != 1)
				{
					if (NumericHelper.IntCmpEq(@int, 0L))
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
						anon_izyfb8.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
						Int128 int12 = @int;
						sbyte val = anon_izyfb8.val;
						int3 = int12;
						Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val, *(long*)(&int3), ((long*)(&int3))[1]);
						Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
						*(double*)cx = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi4);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
						fputil_raise_except_if_required.Invoke(1);
						result = 1;
						num4 = 1;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						anon_izyfb9.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
						Int128 int13 = @int;
						sbyte val2 = anon_izyfb9.val;
						int4 = int13;
						Struct_fiz2nb struct_fiz2nb7 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val2, *(long*)(&int4), ((long*)(&int4))[1]);
						Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb8.field_0;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb9.field_1;
						*(double*)cx = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi5);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						fputil_raise_except_if_required.Invoke(1);
						result = 1;
						num4 = 1;
					}
				}
				else if ((b & 1) != 1 && (b2 & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
					anon_izyfb10.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
					Int128 int14 = @int;
					sbyte val3 = anon_izyfb10.val;
					int5 = int14;
					Struct_fiz2nb struct_fiz2nb10 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val3, *(long*)(&int5), ((long*)(&int5))[1]);
					Int128* ptr3 = &fputil_FPBits_ubgsi6.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb11.field_0;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb12.field_1;
					*(double*)cx = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi6);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
					fputil_raise_except_if_required.Invoke(1);
					result = 1;
					num4 = 1;
				}
				else
				{
					if (!details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi3), expected: false))
					{
						*(double*)cx = *(double*)x;
						goto IL_07ca;
					}
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
					anon_izyfb11.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
					Struct_fiz2nb struct_fiz2nb13 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num5 = &int6;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					*(long*)num5 = struct_fiz2nb14.field_0;
					byte* num6 = (byte*)(&int6) + 8u;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					*(long*)num6 = struct_fiz2nb15.field_1;
					Int128 int15 = int6;
					sbyte val4 = anon_izyfb11.val;
					int7 = int15;
					Struct_fiz2nb struct_fiz2nb16 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val4, *(long*)(&int7), ((long*)(&int7))[1]);
					Int128* ptr4 = &fputil_FPBits_ubgsi7.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
					((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb17.field_0;
					Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
					((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb18.field_1;
					*(double*)cx = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi7);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
					fputil_raise_except_if_required.Invoke(1);
					result = 1;
					num4 = 1;
				}
			}
			else
			{
				if (num == 0 && (b & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
					int8 = @int;
					Struct_fiz2nb struct_fiz2nb19 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_make_value.Invoke(*(long*)(&int8), ((long*)(&int8))[1], 0);
					Int128* ptr5 = &fputil_FPBits_ubgsi8.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
					((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb20.field_0;
					Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
					((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb21.field_1;
					*(double*)cx = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi8);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
					goto IL_07ca;
				}
				if (num != 0 && (b & 1) != 1)
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
					anon_izyfb12.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
					Int128 int16 = @int;
					sbyte val5 = anon_izyfb12.val;
					int9 = int16;
					Struct_fiz2nb struct_fiz2nb22 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val5, *(long*)(&int9), ((long*)(&int9))[1]);
					Int128* ptr6 = &fputil_FPBits_ubgsi9.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
					((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb23.field_0;
					Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
					((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb24.field_1;
					*(double*)cx = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi9);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
					fputil_raise_except_if_required.Invoke(1);
					result = 1;
					num4 = 1;
				}
				else
				{
					if (!details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi3), expected: false))
					{
						*(double*)cx = *(double*)x;
						goto IL_07ca;
					}
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
					anon_izyfb13.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
					Struct_fiz2nb struct_fiz2nb25 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num7 = &int10;
					Struct_fiz2nb struct_fiz2nb26 = struct_fiz2nb25;
					*(long*)num7 = struct_fiz2nb26.field_0;
					byte* num8 = (byte*)(&int10) + 8u;
					Struct_fiz2nb struct_fiz2nb27 = struct_fiz2nb25;
					*(long*)num8 = struct_fiz2nb27.field_1;
					Int128 int17 = int10;
					sbyte val6 = anon_izyfb13.val;
					int11 = int17;
					Struct_fiz2nb struct_fiz2nb28 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val6, *(long*)(&int11), ((long*)(&int11))[1]);
					Int128* ptr7 = &fputil_FPBits_ubgsi10.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb29 = struct_fiz2nb28;
					((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb29.field_0;
					Struct_fiz2nb struct_fiz2nb30 = struct_fiz2nb28;
					((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb30.field_1;
					*(double*)cx = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi10);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
					fputil_raise_except_if_required.Invoke(1);
					result = 1;
					num4 = 1;
				}
			}
			goto IL_07cf;
		}
		IL_07ca:
		num4 = 0;
		goto IL_07cf;
		IL_07cf:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(16L, &@int);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		switch (num4)
		{
		case 0:
			result = 0;
			break;
		}
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
	}
}
