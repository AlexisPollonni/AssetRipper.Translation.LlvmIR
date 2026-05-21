using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_args_to_index
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE13args_to_indexEm")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::args_to_index(unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_scanf_core_Parser* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		unchecked
		{
			if ((ulong)This->Args_index > (ulong)Index)
			{
				This->Args_index = 1L;
				ArgList_Assignment.Invoke(Rhs: &This->Args_start, This: &This->Args_cur);
			}
			while ((ulong)This->Args_index < (ulong)Index)
			{
				ArgList_next_var_void.Invoke(&This->Args_cur);
				This->Args_index++;
			}
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13args_to_indexEm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::args_to_index(unsigned long)")]
	public unsafe static bool Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		bool result = false;
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc2 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
		Llvm_libc_20_1_2_printf_core_TypeDesc llvm_libc_20_1_2_printf_core_TypeDesc3 = default(Llvm_libc_20_1_2_printf_core_TypeDesc);
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
		unchecked
		{
			if ((ulong)This->Args_index > (ulong)Index)
			{
				This->Args_index = 1L;
				ArgList_Assignment.Invoke(Rhs: &This->Args_start, This: &This->Args_cur);
			}
			while (true)
			{
				if ((ulong)This->Args_index < (ulong)Index)
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc);
					Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, 0, 2L, isVolatile: false);
					if ((ulong)This->Args_index <= 128uL)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, (byte*)(&This->Desc_arr) + (nint)(This->Args_index - 1L) * sizeof(Llvm_libc_20_1_2_printf_core_TypeDesc), 2L, isVolatile: false);
					}
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc2);
					*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc2) = Printf_core_type_desc_from_type_void_kvifr8.Invoke();
					bool num = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc2);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc2);
					if (num)
					{
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc3);
						*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc3) = Parser_internal_ArgList_get_type_desc.Invoke(This, This->Args_index);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc3, 2L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc3);
					}
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc4);
					*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc4) = Printf_core_type_desc_from_type_void_kvifr8.Invoke();
					bool num2 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc4);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc4);
					int num3;
					if (num2)
					{
						result = false;
						num3 = 1;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc5);
						*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc5) = Printf_core_type_desc_from_type_unsigned_int.Invoke();
						bool num4 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc5);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc5);
						if (num4)
						{
							ArgList_next_var_unsigned_int.Invoke(&This->Args_cur);
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc6);
							*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc6) = Printf_core_type_desc_from_type_unsigned_long.Invoke();
							bool num5 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc6);
							Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc6);
							if (num5)
							{
								ArgList_next_var_unsigned_long.Invoke(&This->Args_cur);
							}
							else
							{
								Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc7);
								*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc7) = Printf_core_type_desc_from_type_double.Invoke();
								bool num6 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc7);
								Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc7);
								if (num6)
								{
									ArgList_next_var_double.Invoke(&This->Args_cur);
								}
								else
								{
									Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc8);
									*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc8) = Printf_core_type_desc_from_type_long_double.Invoke();
									bool num7 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc8);
									Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc8);
									if (num7)
									{
										ArgList_next_var_long_double.Invoke(&This->Args_cur);
									}
									else
									{
										Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc9);
										*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc9) = Printf_core_type_desc_from_type_short_Fract.Invoke();
										bool num8 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc9);
										Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc9);
										if (num8)
										{
											ArgList_next_var_short_Fract.Invoke(&This->Args_cur);
										}
										else
										{
											Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc10);
											*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc10) = Printf_core_type_desc_from_type_Fract.Invoke();
											bool num9 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc10);
											Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc10);
											if (num9)
											{
												ArgList_next_var_Fract.Invoke(&This->Args_cur);
											}
											else
											{
												Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc11);
												*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc11) = Printf_core_type_desc_from_type_long_Fract.Invoke();
												bool num10 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc11);
												Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc11);
												if (num10)
												{
													ArgList_next_var_long_Fract.Invoke(&This->Args_cur);
												}
												else
												{
													Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc12);
													*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc12) = Printf_core_type_desc_from_type_short_Accum.Invoke();
													bool num11 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc12);
													Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc12);
													if (num11)
													{
														ArgList_next_var_short_Accum.Invoke(&This->Args_cur);
													}
													else
													{
														Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc13);
														*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc13) = Printf_core_type_desc_from_type_Accum.Invoke();
														bool num12 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc13);
														Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc13);
														if (num12)
														{
															ArgList_next_var_Accum.Invoke(&This->Args_cur);
														}
														else
														{
															Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc14);
															*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc14) = Printf_core_type_desc_from_type_long_Accum.Invoke();
															bool num13 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc14);
															Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc14);
															if (num13)
															{
																ArgList_next_var_long_Accum.Invoke(&This->Args_cur);
															}
															else
															{
																Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc15);
																*(short*)(&llvm_libc_20_1_2_printf_core_TypeDesc15) = Printf_core_type_desc_from_type_void_f5fqec.Invoke();
																bool num14 = TypeDesc_Equals.Invoke(&llvm_libc_20_1_2_printf_core_TypeDesc, &llvm_libc_20_1_2_printf_core_TypeDesc15);
																Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc15);
																if (num14)
																{
																	ArgList_next_var_void.Invoke(&This->Args_cur);
																}
																else
																{
																	ArgList_next_var_unsigned_int.Invoke(&This->Args_cur);
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						This->Args_index++;
						num3 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_printf_core_TypeDesc);
					switch (num3)
					{
					case 0:
						continue;
					case 1:
						break;
					default:
						throw new NotImplementedException("Reached LLVM unreachable instruction.");
					}
				}
				else
				{
					result = true;
				}
				break;
			}
			return result;
		}
	}
}
