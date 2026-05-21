using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_type_desc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_type_descEm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_type_desc(unsigned long)")]
	public unsafe static short Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc2 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		long num4 = 0L;
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc3 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_LengthSpec llvm_libc_20_1_2_printf_core_LengthSpec = default(Llvm_libc_20_1_2_printf_core_LengthSpec);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc4 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc5 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc6 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc7 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc8 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc9 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc10 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc11 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc12 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc13 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc14 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc15 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc16 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc17 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc18 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc19 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc20 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc21 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc22 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc23 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			while (true)
			{
				int num5;
				if (((bool*)This->Str)[num])
				{
					if (((sbyte*)This->Str)[num] != 37)
					{
						goto IL_0b26;
					}
					num++;
					Llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = Parser_internal_ArgList_parse_index_rv6qzv.Invoke(This, &num);
					Parser_internal_ArgList_parse_flags.Invoke(This, &num);
					if (((sbyte*)This->Str)[num] == 42)
					{
						num++;
						Llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = Parser_internal_ArgList_parse_index_rv6qzv.Invoke(This, &num);
						long index = num3;
						*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc2) = Printf_core_type_desc_from_type_int.Invoke();
						Parser_internal_ArgList_set_type_desc.Invoke(This, index, *(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc2));
						if (num3 == Index)
						{
							*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc) = Printf_core_type_desc_from_type_int.Invoke();
							num5 = 1;
						}
						else
						{
							num5 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(8L, &num3);
						switch (num5)
						{
						case 0:
							break;
						default:
							goto IL_0b01;
						}
					}
					else if (Internal_isdigit_prmaet.Invoke(((sbyte*)This->Str)[num]))
					{
						for (; Internal_isdigit_prmaet.Invoke(((sbyte*)This->Str)[num]); num++)
						{
						}
					}
					if (((sbyte*)This->Str)[num] == 46)
					{
						num++;
						if (((sbyte*)This->Str)[num] == 42)
						{
							num++;
							Llvm_lifetime_start_p0.Invoke(8L, &num4);
							num4 = Parser_internal_ArgList_parse_index_rv6qzv.Invoke(This, &num);
							long index2 = num4;
							*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc3) = Printf_core_type_desc_from_type_int.Invoke();
							Parser_internal_ArgList_set_type_desc.Invoke(This, index2, *(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc3));
							if (num4 == Index)
							{
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc) = Printf_core_type_desc_from_type_int.Invoke();
								num5 = 1;
							}
							else
							{
								num5 = 0;
							}
							Llvm_lifetime_end_p0.Invoke(8L, &num4);
							switch (num5)
							{
							case 0:
								break;
							default:
								goto IL_0b01;
							}
						}
						else if (Internal_isdigit_prmaet.Invoke(((sbyte*)This->Str)[num]))
						{
							for (; Internal_isdigit_prmaet.Invoke(((sbyte*)This->Str)[num]); num++)
							{
							}
						}
					}
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_LengthSpec);
					*(int*)(&llvm_libc_20_1_2_printf_core_LengthSpec) = -1431655766;
					sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_printf_core_LengthSpec) + 4;
					*ptr = -86;
					ptr[1] = -86;
					ptr[2] = -86;
					ptr[3] = -86;
					((long*)(&llvm_libc_20_1_2_printf_core_LengthSpec))[1] = -6148914691236517206L;
					Struct_nfiam5 struct_nfiam = Parser_internal_ArgList_parse_length_modifier.Invoke(This, &num);
					Llvm_libc_20_1_2_printf_core_LengthSpec* num6 = &llvm_libc_20_1_2_printf_core_LengthSpec;
					Struct_nfiam5 struct_nfiam2 = struct_nfiam;
					*(int*)num6 = struct_nfiam2.field_0;
					byte* num7 = (byte*)(&llvm_libc_20_1_2_printf_core_LengthSpec) + 8u;
					Struct_nfiam5 struct_nfiam3 = struct_nfiam;
					*(long*)num7 = struct_nfiam3.field_1;
					if (num2 == 0L)
					{
						if (((sbyte*)This->Str)[num] != 0)
						{
							num++;
						}
						num5 = 2;
					}
					else
					{
						Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, 0, 2L, isVolatile: false);
						switch (((sbyte*)This->Str)[num])
						{
						case 37:
							Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc4);
							*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc4) = Printf_core_type_desc_from_type_void_kvifr8.Invoke();
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc4, 2L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc4);
							break;
						case 99:
							Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc5);
							*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc5) = Printf_core_type_desc_from_type_int.Invoke();
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc5, 2L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc5);
							break;
						case 66:
						case 88:
						case 98:
						case 100:
						case 105:
						case 111:
						case 117:
						case 120:
							switch (llvm_libc_20_1_2_printf_core_LengthSpec.Lm)
							{
							case LengthModifier_mnvaa2.hh:
							case LengthModifier_mnvaa2.h:
							case LengthModifier_mnvaa2.none:
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc6);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc6) = Printf_core_type_desc_from_type_int.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc6, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc6);
								break;
							case LengthModifier_mnvaa2.l:
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc7);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc7) = Printf_core_type_desc_from_type_long.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc7, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc7);
								break;
							case LengthModifier_mnvaa2.ll:
							case LengthModifier_mnvaa2.L:
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc8);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc8) = Printf_core_type_desc_from_type_long_long.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc8, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc8);
								break;
							case LengthModifier_mnvaa2.j:
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc9);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc9) = Printf_core_type_desc_from_type_long.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc9, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc9);
								break;
							case LengthModifier_mnvaa2.z:
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc10);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc10) = Printf_core_type_desc_from_type_unsigned_long.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc10, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc10);
								break;
							case LengthModifier_mnvaa2.t:
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc11);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc11) = Printf_core_type_desc_from_type_long.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc11, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc11);
								break;
							case LengthModifier_mnvaa2.w:
							case LengthModifier_mnvaa2.wf:
								if ((ulong)llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width <= 32uL)
								{
									Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc12);
									*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc12) = Printf_core_type_desc_from_type_int.Invoke();
									Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc12, 2L, isVolatile: false);
									Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc12);
								}
								else if ((ulong)llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width <= 64uL)
								{
									Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc13);
									*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc13) = Printf_core_type_desc_from_type_long.Invoke();
									Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc13, 2L, isVolatile: false);
									Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc13);
								}
								else if ((ulong)llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width <= 64uL)
								{
									Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc14);
									*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc14) = Printf_core_type_desc_from_type_long_long.Invoke();
									Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc14, 2L, isVolatile: false);
									Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc14);
								}
								else
								{
									Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc15);
									*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc15) = Printf_core_type_desc_from_type_long.Invoke();
									Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc15, 2L, isVolatile: false);
									Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc15);
								}
								break;
							}
							break;
						case 65:
						case 69:
						case 70:
						case 71:
						case 97:
						case 101:
						case 102:
						case 103:
							if (llvm_libc_20_1_2_printf_core_LengthSpec.Lm != LengthModifier_mnvaa2.L)
							{
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc16);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc16) = Printf_core_type_desc_from_type_double.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc16, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc16);
							}
							else
							{
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc17);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc17) = Printf_core_type_desc_from_type_long_double.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc17, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc17);
							}
							break;
						case 82:
						case 114:
							Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc18);
							*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc18) = Printf_core_type_desc_from_type_unsigned_int.Invoke();
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc18, 2L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc18);
							break;
						case 75:
						case 107:
							if (llvm_libc_20_1_2_printf_core_LengthSpec.Lm == LengthModifier_mnvaa2.l)
							{
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc19);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc19) = Printf_core_type_desc_from_type_unsigned_long.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc19, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc19);
							}
							else
							{
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc20);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc20) = Printf_core_type_desc_from_type_unsigned_int.Invoke();
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc20, 2L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc20);
							}
							break;
						case 110:
						case 112:
						case 115:
							Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc21);
							*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc21) = Printf_core_type_desc_from_type_void_f5fqec.Invoke();
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc21, 2L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc21);
							break;
						default:
							Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc22);
							*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc22) = Printf_core_type_desc_from_type_int.Invoke();
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc22, 2L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc22);
							break;
						}
						long index3 = num2;
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc23, &llvm_libc_20_1_2_printf_core_TypeDesc, 2L, isVolatile: false);
						Parser_internal_ArgList_set_type_desc.Invoke(This, index3, *(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc23));
						num5 = ((num2 == Index) ? 1 : 0);
					}
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_LengthSpec);
					goto IL_0b01;
				}
				*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc) = Printf_core_type_desc_from_type_void_kvifr8.Invoke();
				break;
				IL_0b01:
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				int num8 = num5;
				if (num8 != 0)
				{
					if (num8 != 2)
					{
						break;
					}
					continue;
				}
				goto IL_0b26;
				IL_0b26:
				if (((sbyte*)This->Str)[num] != 0)
				{
					num++;
				}
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc);
		}
	}
}
