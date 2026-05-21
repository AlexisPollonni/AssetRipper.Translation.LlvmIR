using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_using_specific_rounding_mode_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil34round_using_specific_rounding_modeIgEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_i")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, __float128>::type __llvm_libc_20_1_2_::fputil::round_using_specific_rounding_mode<__float128>(__float128, int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, __float128>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("rnd")][NativeType("int")] int Rnd)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		sbyte b = 0;
		int num = 0;
		Int128 x = default(Int128);
		int num2 = 0;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 int4 = default(Int128);
		double num3 = 0.0;
		Int128 x2 = default(Int128);
		Int128 x3 = default(Int128);
		Int128 y = default(Int128);
		Int128 x4 = default(Int128);
		Int128 x5 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
			double result;
			if (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)))
			{
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				if (num >= 112)
				{
					result = X;
				}
				else if (num <= -1)
				{
					switch (Rnd)
					{
					case 1:
						result = InstructionHelper.Select((b & 1) == 1, -1.0, 0.0);
						break;
					case 0:
						result = InstructionHelper.Select((b & 1) == 1, -0.0, 1.0);
						break;
					case 2:
						result = InstructionHelper.Select((b & 1) == 1, -0.0, 0.0);
						break;
					case 3:
						result = ((num >= -1) ? InstructionHelper.Select((b & 1) == 1, -1.0, 1.0) : InstructionHelper.Select((b & 1) == 1, -0.0, 0.0));
						break;
					default:
						if (num > -2)
						{
							Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
							Int128* num4 = &x;
							Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
							*(long*)num4 = struct_fiz2nb2.field_0;
							byte* num5 = (byte*)(&x) + 8u;
							Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
							*(long*)num5 = struct_fiz2nb3.field_1;
							if (!NumericHelper.IntCmpEq(x, 0L))
							{
								result = InstructionHelper.Select((b & 1) == 1, -1.0, 1.0);
								break;
							}
						}
						result = InstructionHelper.Select((b & 1) == 1, -0.0, 0.0);
						break;
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(112 - num);
					Llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128* num6 = &int2;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num6 = struct_fiz2nb5.field_0;
					byte* num7 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num7 = struct_fiz2nb6.field_1;
					@int = int2;
					Llvm_lifetime_start_p0.Invoke(16L, &int3);
					int3 = NumericHelper.ShiftLeft(NumericHelper.ShiftRightLogical(@int, (Int128)(UInt128)(uint)num2), (Int128)(UInt128)(uint)num2);
					if (NumericHelper.IntCmpEq(int3, @int))
					{
						result = X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
						*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2) = -6148914691236517206L;
						int4 = int3;
						FPBits_float128_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, *(long*)(&int4), ((long*)(&int4))[1]);
						Llvm_lifetime_start_p0.Invoke(16L, &num3);
						num3 = FPBits_float128_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
						Llvm_lifetime_start_p0.Invoke(16L, &x2);
						Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
						Int128* num8 = &x3;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						*(long*)num8 = struct_fiz2nb8.field_0;
						byte* num9 = (byte*)(&x3) + 8u;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						*(long*)num9 = struct_fiz2nb9.field_1;
						x2 = NumericHelper.BitwiseAnd(x3, NumericHelper.Subtract(NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)num2, x: 1L), 1L));
						Llvm_lifetime_start_p0.Invoke(16L, &y);
						y = NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)(num2 - 1), x: 1L);
						Llvm_lifetime_start_p0.Invoke(16L, &x4);
						Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
						Int128* num10 = &x5;
						Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
						*(long*)num10 = struct_fiz2nb11.field_0;
						byte* num11 = (byte*)(&x5) + 8u;
						Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
						*(long*)num11 = struct_fiz2nb12.field_1;
						x4 = NumericHelper.BitwiseAnd(x5, NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)num2, x: 1L));
						result = Rnd switch
						{
							1 => ((b & 1) != 1) ? num3 : (num3 - 1.0), 
							0 => ((b & 1) != 1) ? (num3 + 1.0) : num3, 
							2 => num3, 
							3 => (!NumericHelper.IntCmpUge(x2, y)) ? num3 : (((b & 1) != 1) ? (num3 + 1.0) : (num3 - 1.0)), 
							_ => NumericHelper.IntCmpUgt(x2, y) ? (((b & 1) != 1) ? (num3 + 1.0) : (num3 - 1.0)) : ((!NumericHelper.IntCmpEq(x2, y)) ? num3 : ((num == 0) ? InstructionHelper.Select((b & 1) == 1, -2.0, 2.0) : ((!NumericHelper.IntCmpNe(x4, 0L)) ? num3 : (((b & 1) != 1) ? (num3 + 1.0) : (num3 - 1.0))))), 
						};
						Llvm_lifetime_end_p0.Invoke(16L, &x4);
						Llvm_lifetime_end_p0.Invoke(16L, &y);
						Llvm_lifetime_end_p0.Invoke(16L, &x2);
						Llvm_lifetime_end_p0.Invoke(16L, &num3);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					}
					Llvm_lifetime_end_p0.Invoke(16L, &int3);
					Llvm_lifetime_end_p0.Invoke(16L, &@int);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			return result;
		}
	}
}
