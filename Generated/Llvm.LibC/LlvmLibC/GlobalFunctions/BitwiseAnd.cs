using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BitwiseAnd
{
	[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm128ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	public unsafe static Struct_fiz2nb Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* rhs)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		long num = 0L;
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			BigInt_128ul_false_unsigned_long_Constructor.Invoke((anon_izyfb7*)(&bigInt_qdkjbh));
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				long num2 = *(long*)BigInt_128ul_false_unsigned_long_Index_ua9ih9.Invoke(lhs, num) & *(long*)BigInt_128ul_false_unsigned_long_Index_ua9ih9.Invoke(rhs, num);
				*(long*)BigInt_128ul_false_unsigned_long_Index_4bextd.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm16ELb0EtEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&, __llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&)")]
	public unsafe static short Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&")] BigInt_ys7s55* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&")] BigInt_ys7s55* rhs)
	{
		BigInt_ys7s55 bigInt_ys7s = default(BigInt_ys7s55);
		long num = 0L;
		unchecked
		{
			*(short*)(&bigInt_ys7s) = -21846;
			BigInt_16ul_false_unsigned_short_Constructor.Invoke(&bigInt_ys7s);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				short num2 = (short)((ushort)(*(short*)BigInt_16ul_false_unsigned_short_Index_z52e5b.Invoke(lhs, num)) & (ushort)(*(short*)BigInt_16ul_false_unsigned_short_Index_z52e5b.Invoke(rhs, num)));
				*(short*)BigInt_16ul_false_unsigned_short_Index_xawi8i.Invoke(&bigInt_ys7s, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(short*)(&bigInt_ys7s.val.Data);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm256ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, [NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* rhs)
	{
		long num = 0L;
		unchecked
		{
			*(long*)agg_result = -6148914691236517206L;
			((long*)agg_result)[1] = -6148914691236517206L;
			((long*)agg_result)[2] = -6148914691236517206L;
			((long*)agg_result)[3] = -6148914691236517206L;
			BigInt_256ul_false_unsigned_long_Constructor.Invoke(agg_result);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				long num2 = *(long*)BigInt_256ul_false_unsigned_long_Index_g5vf7y.Invoke(lhs, num) & *(long*)BigInt_256ul_false_unsigned_long_Index_g5vf7y.Invoke(rhs, num);
				*(long*)BigInt_256ul_false_unsigned_long_Index_mutfrx.Invoke(agg_result, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm32ELb0EjEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&, __llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&")] BigInt_vtm4cw* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&")] BigInt_vtm4cw* rhs)
	{
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		long num = 0L;
		unchecked
		{
			*(int*)(&bigInt_vtm4cw) = -1431655766;
			BigInt_32ul_false_unsigned_int_Constructor.Invoke(&bigInt_vtm4cw);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				int num2 = *(int*)BigInt_32ul_false_unsigned_int_Index_w3q3b2.Invoke(lhs, num) & *(int*)BigInt_32ul_false_unsigned_int_Index_w3q3b2.Invoke(rhs, num);
				*(int*)BigInt_32ul_false_unsigned_int_Index_t9xys9.Invoke(&bigInt_vtm4cw, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(int*)(&bigInt_vtm4cw.val.Data);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm64ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* rhs)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		long num = 0L;
		unchecked
		{
			*(long*)(&bigInt_555ggs) = -6148914691236517206L;
			BigInt_64ul_false_unsigned_long_Constructor.Invoke(&bigInt_555ggs);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				long num2 = *(long*)BigInt_64ul_false_unsigned_long_Index_64yjsu.Invoke(lhs, num) & *(long*)BigInt_64ul_false_unsigned_long_Index_64yjsu.Invoke(rhs, num);
				*(long*)BigInt_64ul_false_unsigned_long_Index_6xqgif.Invoke(&bigInt_555ggs, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(long*)(&bigInt_555ggs.val.Data);
		}
	}
}
